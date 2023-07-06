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
    public partial class Form16 : Form
    {
        private Thread workerThread;
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (workerThread == null || !workerThread.IsAlive)
            {
                // No old thread or old thread has finished, create a new thread
                workerThread = new Thread(() =>
                {
                    // Simulate work
                    for (int i = 1; i <= 10; i++)
                    {
                        // Update the label on the UI thread
                        Invoke((MethodInvoker)delegate
                        {
                            lblStatus.Text = $"Running ({i})";
                        });

                        Thread.Sleep(1000);
                    }

                    // Update the label on the UI thread
                    Invoke((MethodInvoker)delegate
                    {
                        lblStatus.Text = "Finish";
                    });

                    // Create a new thread
                    Thread newThread = new Thread(() => button1_Click(null, null));
                    newThread.Start();
                });

                workerThread.Start();
            }
        }
    }
}
