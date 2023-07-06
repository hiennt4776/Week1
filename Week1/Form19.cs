using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Week1
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            //CreateYellowPanels();
        }

        private void productPanel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void productPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("xxx");
        }

        //private void CreateYellowPanels()
        //{
        //    const int panelCount = 5;
        //    const int panelHeight = 200;
        //    const int panelMargin = 10;

        //    for (int i = 0; i < panelCount; i++)
        //    {
        //        YellowPanel yellowPanel = new YellowPanel();
        //        yellowPanel.Location = new Point(10, (panelHeight + panelMargin) * i + 10);
        //        yellowPanel.Size = new Size(600, panelHeight);
        //        yellowPanel.LabelText = "Label " + (i + 1);
        //        yellowPanel.Button3Click += YellowPanel_Button3Click;

        //        Controls.Add(yellowPanel);
        //    }
        //}

        //private void YellowPanel_Button3Click(object sender, EventArgs e)
        //{
        //    // Get the YellowPanel instance where the button was clicked
        //    YellowPanel yellowPanel = sender as YellowPanel;

        //    // Access the label in the YellowPane update its text
        //    label1.Text = yellowPanel.LabelText;
        //}

    }
}
