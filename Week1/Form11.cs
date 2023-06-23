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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }


        private void panel3_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
           
            
        }

        private void tableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
           
        }
        private void IncreaseSize()
        {

            tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.Width = 80;
            button1.Height = 35;

            button1.Location = new Point(
                     (panel5.Width - button1.Width) / 2,
                     (panel5.Height - button1.Height) / 2
                 );

           
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 550);
        }

        private void DecreaseSize()
        {
            if (!tableLayoutPanel1.ClientRectangle.Contains(tableLayoutPanel1.PointToClient(Control.MousePosition)))
            {
                tableLayoutPanel1.Location = new System.Drawing.Point(50, 50);
                label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button1.Anchor = System.Windows.Forms.AnchorStyles.None;

                button1.Width = 75;
                button1.Height = 30;
                button1.Location = new Point(
                          (panel5.Width - button1.Width) / 2,
                          (panel5.Height - button1.Height) / 2
                      );
              
                this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 500);
            }
        }


        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
             DecreaseSize();
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSize();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSize();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            DecreaseSize();
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSize();
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            DecreaseSize();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSize();
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            DecreaseSize();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSize();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            DecreaseSize();
        }
    }
}
