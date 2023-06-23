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
    public partial class Form7 : Form
    {
        private Panel parentPanel;
        private Panel childPanel;
        public void LoadPanel()
        {
            parentPanel = new Panel();

            parentPanel.Location = new System.Drawing.Point(20, 20);
            parentPanel.Name = "parentPanel";
            parentPanel.Size = new System.Drawing.Size(448, 182);
            parentPanel.TabIndex = 2;
            this.Controls.Add(parentPanel);


            childPanel = new Panel();
            childPanel.BackColor = System.Drawing.Color.Red;
            childPanel.Location = new System.Drawing.Point(20, 20);
            childPanel.Name = "childPanel";
            childPanel.Size = new System.Drawing.Size(200, 100);
            childPanel.TabIndex = 0;
            parentPanel.Controls.Add(childPanel);

            // 
            // childPanel
            // 

            //parentPanel = new Panel();
            //parentPanel.Location = new System.Drawing.Point(20, 20);
            //parentPanel.Size = new System.Drawing.Size(300, 200);
            //parentPanel.BackColor = System.Drawing.Color.LightGray;
            //this.Controls.Add(parentPanel);

            //// Create the child panel

            //childPanel.Location = new System.Drawing.Point(20, 20);
            //childPanel.Size = new System.Drawing.Size(100, 100);
            //childPanel.BackColor = System.Drawing.Color.DarkGray;
            //parentPanel.Controls.Add(childPanel);

        }
        public Form7()
        {
            InitializeComponent();
            LoadPanel();

           

        }
    }
}
