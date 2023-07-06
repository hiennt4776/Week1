using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary5.MyControls
{
    
     
        public class YellowPanel : Panel
        {
            private Button button1;
            private Button button2;
            private Button button3;
            private Label label;
            private int intValue1 = 0;
            private int intValue2 = 0;
            private Label totalLabel;
            private Color button1Color = Color.Red; // Default color is red
            private Color button2Color = Color.Red; // Default color is red
            private Color button1HoverColor = Color.LightBlue; // Default hover color is light blue
            private Color button2HoverColor = Color.LightBlue; // Default hover color is light blue
            private Point normalLocation = new Point();

            public YellowPanel()
            {
            // Set the default background color to yellow
                //Location = normalLocation;
                BackColor = Color.Yellow;
                Size = new Size(300, 500);

                // Create and add two buttons to the panel
                button1 = new Button();
                button1.Text = "Button 1";
                button1.BackColor = button1Color; // Set the default color
                button1.Location = new Point(10, 10);
                button1.Size = new Size(100, 30);
                button1.MouseEnter += Button1_MouseEnter;
                button1.MouseLeave += Button1_MouseLeave;
                Controls.Add(button1);

                button2 = new Button();
                button2.Text = "Button 2";
                button2.BackColor = button2Color; // Set the default color
                button2.Location = new Point(10, 50);
                button2.Size = new Size(100, 30);
                button2.MouseEnter += Button2_MouseEnter;
                button2.MouseLeave += Button2_MouseLeave;
                Controls.Add(button2);
                // Create and add the label to the panel
                label = new Label();
                label.Location = new Point(10, 130);
                label.Text = "demoLabel";
                Controls.Add(label);


                button3 = new Button();
                button3.Text = "Button 3";
                button3.Location = new Point(10, 90);
                button3.Size = new Size(100, 30);

            button3.Tag = label.Text;


                button3.Click += Button3_Click;
                Controls.Add(button3);

              
                // Create and add the total label to the panel
                totalLabel = new Label();
                totalLabel.Location = new Point(10, 170);
                Controls.Add(totalLabel);

                // Update the total label when the values change
              
            }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The location of the label within the YellowPanel.")]
        [Category("Layout")]
        public Point NormalLocation
        {
            get { return normalLocation; }
            set
            {
                normalLocation = value;
                Location = normalLocation;
            }
        }

        [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The color of Button 1.")]
            [Category("Color")]
            public Color Button1Color
            {
                get { return button1Color; }
                set { button1Color = value; button1.BackColor = value; }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The color of Button 2.")]
            [Category("Color")]
            public Color Button2Color
            {
                get { return button2Color; }
                set { button2Color = value; button2.BackColor = value; }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The hover color of Button 1.")]
            [Category("Color")]
            public Color Button1HoverColor
            {
                get { return button1HoverColor; }
                set { button1HoverColor = value; }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The hover color of Button 2.")]
            [Category("Color")]
            public Color Button2HoverColor
            {
                get { return button2HoverColor; }
                set { button2HoverColor = value; }
            }

            

            private void Button1_MouseEnter(object sender, EventArgs e)
            {
                button1.BackColor = button1HoverColor;
            }

            private void Button1_MouseLeave(object sender, EventArgs e)
            {
                button1.BackColor = button1Color;
            }

            private void Button2_MouseEnter(object sender, EventArgs e)
            {
                button2.BackColor = button2HoverColor;
            }

            private void Button2_MouseLeave(object sender, EventArgs e)
            {
                button2.BackColor = button2Color;
            }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Occurs when Button 3 is clicked.")]
        public event EventHandler Button3Click;

        protected virtual void OnButton3Click(EventArgs e)
        {
            Button3Click?.Invoke(this, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Raise the Button3Click event
            OnButton3Click(EventArgs.Empty);
        }

        private void UpdateTotalLabel()
            {
                int total = intValue1 + intValue2;
                totalLabel.Text = "Total: " + total.ToString();
            }

        

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The value of Integer 1.")]
            [Category("Content")]
            public int IntValue1
            {
                get { return intValue1; }
                set { intValue1 = value; UpdateTotalLabel(); }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The value of Integer 2.")]
            [Category("Content")]
            public int IntValue2
            {
                get { return intValue2; }
                set { intValue2 = value; UpdateTotalLabel(); }
            }

            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            [EditorBrowsable(EditorBrowsableState.Always)]
            [Description("The text of the label.")]
            [Category("Content")]
            public string LabelText
            {
                get { return label.Text; }
                set { label.Text = value; }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
        }
    }