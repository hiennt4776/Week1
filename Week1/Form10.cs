
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form10 : Form
    {
        private int panelCount = 0;
        private Dictionary<int, Panel> panels = new Dictionary<int, Panel>();
        private Panel parentPanel;
        private Thread thread = new Thread(() => { });

        public Form10()
        {
            InitializeComponent();
            // Populate the ComboBox with known colors
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                cmbColor.Items.Add(knownColor.ToString());
            }
            CreateParentPanel();
        }

        private void CreateParentPanel()
        {
            parentPanel = new Panel();
            parentPanel.Location = new System.Drawing.Point(125, 9);
            parentPanel.Name = "panelParent";
            parentPanel.Size = new System.Drawing.Size(663, 429);

            Controls.Add(parentPanel);


        }

        private void btnCreatePanel_Click(object sender, EventArgs e)
        {
            //panelCount++;
            //Panel newPanel = new Panel();
            //newPanel.Name = "Panel" + panelCount;

            //// Get the X and Y coordinates from the TextBox input
            //int x = int.Parse(txtLocationX.Text);
            //int y = int.Parse(txtLocationY.Text);
            //newPanel.Location = new Point(x, y);

            //// Set the size of the panel
            //newPanel.Size = new Size(50,50);

            //// Set the color of the panel based on the selected item in the ComboBox
            //string selectedColor = cmbColor.SelectedItem.ToString();
            //Color panelColor = Color.FromName(selectedColor);
            //newPanel.TabIndex = 0;
            //newPanel.BackColor = panelColor;
            //panels.Add(panelCount, newPanel);
            //cmbSelectPanel.Items.Add(newPanel.Name);
            //parentPanel.Controls.Add(newPanel);
            if (parentPanel == null)
            {
                CreateParentPanel();
            }

            panelCount++;
            Panel newPanel = new Panel();
            newPanel.Name = "Panel" + panelCount;
            //int x = int.Parse(txtLocationX.Text);
            //int y = int.Parse(txtLocationY.Text);
            newPanel.Location = new Point(500, 100);
            newPanel.Size = new Size(50, 50);
            //string selectedColor = cmbColor.SelectedItem.ToString();
            Color panelColor = Color.Red;
            newPanel.BackColor = panelColor;
            Label nameLabel = new Label();
            nameLabel.Text = newPanel.Name;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 10); // Adjust the label's position as needed

            newPanel.Controls.Add(nameLabel);

            panels.Add(panelCount, newPanel);
            cmbSelectPanel.Items.Add(newPanel.Name);
            parentPanel.Controls.Add(newPanel);
        }

        private void btnDeletePanel_Click(object sender, EventArgs e)
        {
            string selectedPanelName = cmbSelectPanel.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedPanelName))
            {
                int panelNumber = int.Parse(selectedPanelName.Replace("Panel", ""));
                Panel panelToDelete = panels[panelNumber];

                Controls.Remove(panelToDelete);
                panelToDelete.Dispose();
                panels.Remove(panelNumber);
                cmbSelectPanel.Items.Remove(selectedPanelName);
                cmbSelectPanel.SelectedIndex = -1;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panels.Values)
            {
                parentPanel.Controls.Remove(panel);
                panel.Dispose();
            }

            panels.Clear();
            cmbSelectPanel.Items.Clear();
            cmbSelectPanel.SelectedIndex = -1;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            int distance = int.Parse(txtDistance.Text);
            foreach (Panel panel in panels.Values)
            {
                for (int i = 0; i < distance; i++)
                {
                    panel.Top -= 1;
                }
            
            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            int distance = int.Parse(txtDistance.Text);
            foreach (Panel panel in panels.Values)
            {
                for (int i = 0; i < distance; i++)
                {
                    panel.Top += 1;
                }
            }
        }
        private void MovePanels(int distance)
        {
            //thread.Abort();
            //thread = new Thread(() =>
            //{
            //    for (int j = 0; j < distance; j++)
            //    {
            //        Thread.Sleep(0);
            //        BeginInvoke(new Action(() =>
            //        {
            //            foreach (Control control in parentPanel.Controls)
            //            {
            //                if (control is Panel panel)
            //                {
            //                    panel.Left += 1;
            //                }
            //            }
            //        }));
            //    }
            //});
            //thread.Start();


            //for (int j = 0; j < maxFor; j++)
            //{
            //    foreach (Control control in parentPanel.Controls)
            //    {
            //        if (control is Panel panel)
            //        {
            //            panel.Left += distance;
            //        }
            //    }

            //}

            //foreach (Control control in parentPanel.Controls)
            //{
            //    if (control is Panel panel)
            //    {
            //        panel.Left += maxFor * distance;

            //    }
            //}


        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //int distance = int.Parse(txtDistance.Text);

            //foreach (Panel panel in panels.Values)
            //{
            //    for(int i = 0; i < distance; i++)
            //    {
            //        panel.Left -= 1;
            //    }

            //}
            MovePanels(20);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MovePanels(-20);
            //int distance = int.Parse(txtDistance.Text);
            //foreach (Panel panel in panels.Values)
            //{
            //    for (int i = 0; i < distance; i++)
            //    {
            //        panel.Left += 1;
            //    }
            //}
        }
    }
}
