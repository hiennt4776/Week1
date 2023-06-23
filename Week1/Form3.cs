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
    public partial class Form3 : Form
    {
        private const int EnlargedSize = 150; // Adjust this value as needed
        private const int AnimationInterval = 20; // Adjust this value as needed

        private Size originalSize;
        private Point originalLocation;

        private int currentSizeChange;
        private bool isEnlarging;

        public Form3()
        {
            InitializeComponent();
            originalSize = button1.Size;
            originalLocation = button1.Location;
            originalSize = button1.Size;
          

          

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "MouseHover";
        
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.Text = "MouseLeave";
            //button1.Size = originalSize;
            //button1.Location = new Point(button1.Location.X + (EnlargedSize / 2), button1.Location.Y + (EnlargedSize / 2));
          
            currentSizeChange = 0;
            isEnlarging = false;
            button1.Location = originalLocation;
            //animationTimer.Start();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button1.Text = "MouseEnter";
            //button1.Size = new Size(originalSize.Width + EnlargedSize, originalSize.Height + EnlargedSize);
            //button1.Location = new Point(button1.Location.X - (EnlargedSize / 2), button1.Location.Y - (EnlargedSize / 2));
            currentSizeChange = 0;
            isEnlarging = true;
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            const int totalFrames = EnlargedSize / AnimationInterval;
            const int sizeChangePerFrame = EnlargedSize / totalFrames;

            if (isEnlarging)
            {
                currentSizeChange += sizeChangePerFrame;
                if (currentSizeChange >= EnlargedSize)
                {
                    currentSizeChange = EnlargedSize;
                    animationTimer.Stop();
                }
            }
            else
            {
                currentSizeChange -= sizeChangePerFrame;
                if (currentSizeChange <= 0)
                {
                    currentSizeChange = 0;
                    animationTimer.Stop();
                }
            }

            int newSize = originalSize.Width + currentSizeChange;
            button1.Size = new Size(newSize, newSize);
            button1.Location = new Point(
                originalLocation.X - (currentSizeChange / 2),
                originalLocation.Y - (currentSizeChange / 2));
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = originalLocation;
        }
    }
}
