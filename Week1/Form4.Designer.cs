using System.Drawing;
using System.Windows.Forms;
using System;

namespace Week1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowMessageBox = new Button();
            this.lblButtonValue = new Label();
            this.numericUpDownButtons = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownButtons)).BeginInit();
            this.SuspendLayout();

            // btnShowMessageBox
            this.btnShowMessageBox.Location = new Point(50, 50);
            this.btnShowMessageBox.Name = "btnShowMessageBox";
            this.btnShowMessageBox.Size = new Size(150, 30);
            this.btnShowMessageBox.Text = "Show Message Box";
            this.btnShowMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMessageBox.Click += new EventHandler(this.btnShowMessageBox_Click);

            // lblButtonValue
            this.lblButtonValue.AutoSize = true;
            this.lblButtonValue.Location = new Point(50, 100);
            this.lblButtonValue.Name = "lblButtonValue";
            this.lblButtonValue.Size = new Size(0, 17);

            // numericUpDownButtons
            this.numericUpDownButtons.Location = new Point(220, 53);
            this.numericUpDownButtons.Minimum = 1;
            this.numericUpDownButtons.Maximum = 10;
            this.numericUpDownButtons.Name = "numericUpDownButtons";
            this.numericUpDownButtons.Size = new Size(45, 22);

            // MainForm
            this.ClientSize = new Size(300, 150);
            this.Controls.Add(this.btnShowMessageBox);
            this.Controls.Add(this.lblButtonValue);
            this.Controls.Add(this.numericUpDownButtons);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownButtons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}