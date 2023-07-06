using ClassLibrary5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace ClassLibrary5.MyControls
{
    public class CarouselPanel : Panel
    {
        private Button buttonBack;
        private Button buttonNext;
        private Label label;
        private Label labelPosition1;
        private Label labelPosition2;
        private Label totalLabel;
        private int zoomDistanceButtonX = 10;
        private int zoomDistanceButtonY = 10;
        private Color buttonColor = Color.Red;
        private Color buttonColorChange = Color.Green;
        private int panelMoveDistanceAfterSleep = 4;
        private int distanceMove = 400;
        private int timerSleep = 1;
        private int First = 0;
        private int Last = 0;
        //private int maxFor = distanceMove / PanelMoveDistanceAfterSleep; //phai chia het
        private bool isMouseDown;

        private Thread thread = new Thread(() => { });
        public CarouselPanel()
        {

            InitializeControls();
        }

        private void InitializeControls()
        {
            // Set the default background color to yellow
            this.BackColor = Color.Yellow;


            this.Size = new Size(1200, 600);
       
            this.MouseDown += CarouselPanel_MouseDown;
            this.MouseUp += CarouselPanel_MouseUp;
            //MouseHover += CarouselPanel_MouseHover;
            
            // Create and add two buttons to the panel
            buttonBack = new Button();
            buttonBack.AutoSize = true;
            buttonBack.Text = "<";
            //buttonBack.AutoSize = true;

            buttonBack.Location = new Point(30, 30);
            buttonBack.MouseEnter += buttonBack_MouseEnter;
            buttonBack.MouseLeave += buttonBack_MouseLeave;
            buttonBack.Click += buttonBack_Click;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBack.BackColor = buttonColor;
            Controls.Add(buttonBack);

            buttonNext = new Button();
            buttonBack.AutoSize = true;
            buttonNext.Text = ">";

            buttonNext.Location = new Point(150, 30);
            buttonNext.MouseEnter += buttonNext_MouseEnter;
            buttonNext.MouseLeave += buttonNext_MouseLeave;
            buttonNext.Click += buttonNext_Click;
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonNext.BackColor = buttonColor;

            buttonBack.Enabled = checkPanelLocationSmaller0();
            //buttonNext.Enabled = checkPanelLocationLargeSize();
            Controls.Add(buttonNext);
            labelPosition1 = new Label();
            labelPosition1.Text = "zzz";
            labelPosition1.Location = new Point(300, 30);
            Controls.Add(labelPosition1);

            labelPosition2 = new Label();
            labelPosition2.Text = "zzz";
            labelPosition2.Location = new Point(400, 30);
            Controls.Add(labelPosition2);
            isMouseDown = false;


        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The location of Button Back.")]
        [Category("SetNew")]

        public Point ButtonBackLocation
        {
            get { return buttonBack.Location; }
            set { buttonBack.Location = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The location of Button Next.")]
        [Category("SetNew")]

        public Point ButtonNextLocation
        {
            get { return buttonNext.Location; }
            set { buttonNext.Location = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The first integer value.")]
        [Category("SetNew")]

        public int ZoomDistanceButtonX
        {
            get { return zoomDistanceButtonX; }
            set { zoomDistanceButtonX = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The second integer value.")]
        [Category("SetNew")]

        public int ZoomDistanceButtonY
        {
            get { return zoomDistanceButtonY; }
            set { zoomDistanceButtonY = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The color of Button")]

        [Category("SetNew")]

        public Color ButtonColorChange
        {
            get { return buttonColorChange; }
            set { buttonColorChange = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The hover color of Button 1")]
     
        [Category("SetNew")]

        public Color ButtonColor
        {
            get { return buttonColor; }
            set { buttonColor = value; }
        }

        //private int panelMoveDistanceAfterSleep = 4;
        //private int distanceMove = 400;
        //private int TimerSleep = 1;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Panel Move Distance After Sleep")]

        [Category("SetNew")]

        public int PanelMoveDistanceAfterSleep
        {
            get { return panelMoveDistanceAfterSleep; }
            set { panelMoveDistanceAfterSleep = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Distance Move")]

        [Category("SetNew")]

        public int DistanceMove
        {
            get { return distanceMove; }
            set { distanceMove = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Timer Sleep")]

        [Category("SetNew")]

        public int TimerSleep
        {
            get { return timerSleep; }
            set { timerSleep = value; }
        }


     

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.Location = new Point(buttonBack.Location.X - zoomDistanceButtonX / 2, buttonBack.Location.Y - zoomDistanceButtonY / 2);
            buttonBack.Width += zoomDistanceButtonX;
            buttonBack.Height += zoomDistanceButtonY;
            buttonBack.BackColor = buttonColorChange;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {


            buttonBack.Location = new Point(buttonBack.Location.X + zoomDistanceButtonX / 2, buttonBack.Location.Y + zoomDistanceButtonY / 2);
            buttonBack.Width -= zoomDistanceButtonX;
            buttonBack.Height -= zoomDistanceButtonY;
            buttonBack.BackColor = buttonColor;
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.Location = new Point(buttonNext.Location.X - zoomDistanceButtonX / 2, buttonNext.Location.Y - zoomDistanceButtonY / 2);
            buttonNext.Width += zoomDistanceButtonX;
            buttonNext.Height += zoomDistanceButtonY;
            buttonNext.BackColor = buttonColorChange;
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {


            buttonNext.Location = new Point(buttonNext.Location.X + zoomDistanceButtonX / 2, buttonNext.Location.Y + zoomDistanceButtonY / 2);
            buttonNext.Width -= zoomDistanceButtonX;
            buttonNext.Height -= zoomDistanceButtonY;
            buttonNext.BackColor = buttonColor;
        }

        public void Back() {
            if (checkPanelLocationSmaller0())
            {
                int maxFor = distanceMove / panelMoveDistanceAfterSleep;
                if (thread == null || !thread.IsAlive)
                {

                    //MovePanels(PanelMoveDistanceAfterSleep);
                    thread = new Thread(() =>
                    {
                        for (int j = 0; j < maxFor; j++)
                        {
                            Thread.Sleep(timerSleep);
                            BeginInvoke(new Action(() =>
                            {
                                foreach (Control control in this.Controls)
                                {
                                    if (control is Panel panel)
                                    {
                                        panel.Left += panelMoveDistanceAfterSleep;
                                        panel.Enabled = false;
                                    }

                                }



                            }));
                        }
                        Invoke(new Action(() =>
                        {
                            buttonBack.Enabled = checkPanelLocationSmaller0();
                            buttonNext.Enabled = checkPanelLocationLargeSize();
                            foreach (Control control in this.Controls)
                            {
                                if (control is Panel panel)
                                {

                                    panel.Enabled = true;
                                }

                            }
                            //MessageBox.Show("checkPanelLocationSmaller0() = " + checkPanelLocationSmaller0().ToString() + "= checkPanelLocationLargeSize() = " + checkPanelLocationLargeSize().ToString());

                        }));


                    });
                    thread.Start();



                }
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        public void Next()
        {
            if (checkPanelLocationLargeSize())
            {
                int maxFor = distanceMove / panelMoveDistanceAfterSleep;
                if (thread == null || !thread.IsAlive)
                {

                    //MovePanels(PanelMoveDistanceAfterSleep);
                    thread = new Thread(() =>
                    {
                        for (int j = 0; j < maxFor; j++)
                        {
                            Thread.Sleep(timerSleep);
                            BeginInvoke(new Action(() =>
                            {
                                foreach (Control control in this.Controls)
                                {
                                    if (control is Panel panel)
                                    {
                                        panel.Left -= panelMoveDistanceAfterSleep;
                                        panel.Enabled = false;
                                    }
                                }

                            }));
                        }


                        Invoke(new Action(() =>
                        {
                            buttonBack.Enabled = checkPanelLocationSmaller0();
                            buttonNext.Enabled = checkPanelLocationLargeSize();
                            foreach (Control control in this.Controls)
                            {
                                if (control is Panel panel)
                                {

                                    panel.Enabled = true;
                                }

                            }
                            //MessageBox.Show("checkPanelLocationSmaller0() = " + checkPanelLocationSmaller0().ToString() + "= checkPanelLocationLargeSize() = " + checkPanelLocationLargeSize().ToString());

                        }));


                    });
                    thread.Start();


                }

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            Next();
        }
        private bool checkPanelLocationSmaller0()
        {
            bool check = false;
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    if (panel.Location.X < 0)
                    {
                        check = true;
                        break;
                    }
                       
                }
            }
            return check;
        }

        private bool checkPanelLocationLargeSize()
        {
            bool check = false;
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    if (panel.Location.X + panel.Width > Size.Width) {
                        check = true;
                        break;
                    }
                      
                }
            }
            return check;
        }

        private void CarouselPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //labelPosition1.Text = e.X.ToString();           
        }

    

        private void CarouselPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //labelPosition1.Text = e.X.ToString();
            if (e.Button == MouseButtons.Left)
            {
                First = e.X;
                labelPosition1.Text = First.ToString();
                
            }
        }


        private void CarouselPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //labelPosition1.Text = e.X.ToString();
            if (e.Button == MouseButtons.Left)
            {
                Last = e.X;
                labelPosition2.Text = Last.ToString();
                if (First > Last)
                {

                    if (checkPanelLocationLargeSize())
                    {
                        Next();
                    }
                };
                if(First < Last)
                {
                    if (checkPanelLocationSmaller0())
                    {
                        Back();
                    }
                       
                }
            }
         }

    }
}
