namespace Week1
{
    partial class Form18
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
            this.carouselPanel1 = new Week1.MyControls.CarouselPanel();
            this.SuspendLayout();
            // 
            // carouselPanel1
            // 
            this.carouselPanel1.BackColor = System.Drawing.Color.Yellow;
            this.carouselPanel1.ButtonBackLocation = new System.Drawing.Point(30, 30);
            this.carouselPanel1.ButtonColor = System.Drawing.Color.Red;
            this.carouselPanel1.ButtonColorChange = System.Drawing.Color.Green;
            this.carouselPanel1.ButtonNextLocation = new System.Drawing.Point(150, 30);
            this.carouselPanel1.Location = new System.Drawing.Point(58, 35);
            this.carouselPanel1.Name = "carouselPanel1";
            this.carouselPanel1.Size = new System.Drawing.Size(730, 380);
            this.carouselPanel1.TabIndex = 0;
            this.carouselPanel1.ZoomDistanceButtonX = 10;
            this.carouselPanel1.ZoomDistanceButtonY = 10;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.carouselPanel1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.CarouselPanel carouselPanel1;
    }
}