using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace Week1
{
    public partial class Form6 : Form
    {
        private const int PanelMoveDistance = 1;
        private const int setInterval = 60000;
        private const int setSleep = 50;
        private const int maxFor = 200;
        //private Timer moveTimer;

        private int i = 0;
        private bool isIncreasing = false;
        private bool isDecreasing = false;
        private bool isMoving = false;

        Thread threadz = new Thread(() =>{});

        public Form6()
        {
            InitializeComponent();
            LoadTimes();
        }

        static void InitializeThread()
        {
            
        }

        private void LoadTimes()
        {
            // Start a timer to update the label every 30 seconds
            System.Threading.Timer timer = new System.Threading.Timer(UpdateLabel, null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
        }
        private void UpdateLabel(object state)
        {
            // Run this code on the UI thread
            BeginInvoke(new Action(() =>
            {
                lblLocation.Text = i.ToString();
            }));
        }

        private void UpdateLocationPanel(object state)
        {
            // Run this code on the UI thread
            BeginInvoke(new Action(() =>
            {
                lblLocation.Text = i.ToString();
            }));
        }

        private void LeftButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Stop the timer if it's already running
            //MoveChildPanelLeft();
            //UpdatePositionLabel();
         
        }

      

        private void RightButton_Click(object sender, EventArgs e)
        {

            // Stop the timer if it's already running
            //moveTimer?.Stop();

            //// Start the timer with a 5-second interval
            //moveTimer = new System.Windows.Forms.Timer { Interval = setInterval };
            //moveTimer.Tick += (timerSender, timerEventArgs) =>
            //{

            //    moveTimer.Stop();
            //};
            //moveTimer.Start();
            //MoveChildPanelRight();
            //UpdatePositionLabel();

            threadz.Abort();
            threadz = new Thread(() =>
            {
                for (int j = 0; j < maxFor; j++)
                {
                    Thread.Sleep(setSleep); // Simulate delay between increments

                    // Increment i on the UI thread
                    BeginInvoke(new Action(() =>
                    {
                        var newPosition = childPanel.Location.X + PanelMoveDistance;
                        var newPosition2 = childPanel2.Location.X + PanelMoveDistance;

                        // If the panel reaches the right boundary of the parent panel, wrap around to the left side
                        if (newPosition + childPanel.Width > parentPanel.Width)
                        {
                            newPosition = 0;
                        }
                        childPanel.Location = new Point(newPosition, childPanel.Location.Y);
                        childPanel2.Location = new Point(newPosition2, childPanel.Location.Y);
                    }));
                }

                isIncreasing = false;
            });

            threadz.Start();

        }

        private void childPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.Text = "MouseMove";
        }

        private void childPanel_MouseCaptureChanged(object sender, EventArgs e)
        {

            //label1.Text = "MouseCaptureChanged";
        }

        private void childPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lblLocation.Text = "MouseDown";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            childPanel.Location = new Point(0, 0);
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            threadz.Abort();
            threadz = new Thread(() =>
            {
                for (int j = 0; j < maxFor; j++)
                {
                    Thread.Sleep(setSleep); // Simulate delay between increments

                    // Increment i on the UI thread
                    BeginInvoke(new Action(() =>
                    {
                        
                        var newPosition = childPanel.Location.X - PanelMoveDistance;
                        var newPosition2 = childPanel2.Location.X - PanelMoveDistance;

                        // If the panel reaches the left boundary of the parent panel, wrap around to the right side
                        if (newPosition < 0)
                        {
                            newPosition = parentPanel.Width - childPanel.Width;
                        }

                        childPanel.Location = new Point(newPosition, childPanel.Location.Y);
                        childPanel2.Location = new Point(newPosition2, childPanel.Location.Y);
                    }));
                }

                isIncreasing = false;
            });

            threadz.Start();
        }
        private void MoveChildPanelLeft()
        {
            for (int i = 0; i < maxFor; i++)
            {
                moveTimer?.Stop();

                // Start the timer with a 5-second interval
                moveTimer = new System.Windows.Forms.Timer { Interval = setInterval };
                moveTimer.Tick += (timerSender, timerEventArgs) =>
                {

                    moveTimer.Stop();
                };
                var newPosition = childPanel.Location.X - PanelMoveDistance;

                // If the panel reaches the left boundary of the parent panel, wrap around to the right side
                if (newPosition < 0)
                {
                    newPosition = parentPanel.Width - childPanel.Width;
                }

                childPanel.Location = new Point(newPosition, childPanel.Location.Y);
                moveTimer.Start();

            }

           
        }

        private void MoveChildPanelRight()
        {
            for (int i = 0; i < maxFor; i++)
            {
                moveTimer?.Stop();

                // Start the timer with a 5-second interval
                moveTimer = new System.Windows.Forms.Timer { Interval = setInterval };
                moveTimer.Tick += (timerSender, timerEventArgs) =>
                {
                    moveTimer.Stop();
                };
                var newPosition = childPanel.Location.X + PanelMoveDistance;

                // If the panel reaches the right boundary of the parent panel, wrap around to the left side
                if (newPosition + childPanel.Width > parentPanel.Width)
                {
                    newPosition = 0;
                }

                childPanel.Location = new Point(newPosition, childPanel.Location.Y);
                moveTimer.Start();
            }


        }
        private void UpdatePositionLabel()
        {
            lblLocation.Text = $"Child Panel Position: ({childPanel.Location.X}, {childPanel.Location.Y})";
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            //if (!isIncreasing && !isDecreasing)
            //{
                isIncreasing = true;
                isDecreasing = false;


            // Run the loop on a separate thread
                threadz.Abort();
                threadz = new Thread(() =>
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Thread.Sleep(500); // Simulate delay between increments

                        // Increment i on the UI thread
                        BeginInvoke(new Action(() =>
                        {
                            i++;
                            label1.Text = i.ToString();
                        }));
                    }

                    isIncreasing = false;
                });

                threadz.Start();
            //}

        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            //if (!isIncreasing && !isDecreasing)
            //{
                isDecreasing = true;
                isIncreasing = false;
            threadz.Abort();
            threadz = new Thread(() =>
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Thread.Sleep(500); // Simulate delay between decrements

                        // Decrement i on the UI thread
                        BeginInvoke(new Action(() =>
                        {
                            i--;
                            label1.Text = i.ToString();
                        }));
                    }

                    isDecreasing = false;
                });

                threadz.Start();
            //}
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadz.Abort();
        }
    }

}

