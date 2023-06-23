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
    public partial class Form4 : Form
    {
        private Button btnShowMessageBox;
        private Label lblButtonValue;
        private NumericUpDown numericUpDownButtons;
        private int resultIndex;
        public Form4()
        {
            InitializeComponent();
          
        }
        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            int numberOfButtons = (int)numericUpDownButtons.Value;

            string[] buttonLabels = Enumerable.Range(1, numberOfButtons).Select(n => n.ToString()).ToArray();
            DialogResult result = ShowCustomMessageBox("Choose a button:", "Message Box", buttonLabels);

            lblButtonValue.Text = (result == DialogResult.OK && buttonLabels.Length >= resultIndex) ? buttonLabels[resultIndex] : "";
        }

        private DialogResult ShowCustomMessageBox(string message, string title, string[] buttonLabels)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = DialogResult.OK;

            using (Form messageBox = new Form())
            {
                messageBox.StartPosition = FormStartPosition.CenterParent;
                messageBox.FormBorderStyle = FormBorderStyle.FixedDialog;
                messageBox.MaximizeBox = false;
                messageBox.MinimizeBox = false;
                messageBox.Text = title;

                Label lblMessage = new Label();
                lblMessage.Text = message;
                lblMessage.AutoSize = true;
                lblMessage.Location = new Point(20, 20);

                Button[] buttonsArray = new Button[buttonLabels.Length];

                for (int i = 0; i < buttonLabels.Length; i++)
                {
                    Button button = new Button();
                    button.Text = buttonLabels[i];
                    button.DialogResult = DialogResult.OK;
                    button.Location = new Point(20 + i * 80, 50);
                    int resultIndex = i; // Store the index in a separate variable to capture it in the lambda expression
                    button.Click += (sender, e) => { result = DialogResult.OK; resultIndex = i; messageBox.Close(); };
                    buttonsArray[i] = button;
                }

                messageBox.ClientSize = new Size(60 + buttonLabels.Length * 80, 100);
                messageBox.Controls.AddRange(new Control[] { lblMessage });
                messageBox.Controls.AddRange(buttonsArray);
                messageBox.ShowDialog();
            }

            return result;
        }
    
    }
}
