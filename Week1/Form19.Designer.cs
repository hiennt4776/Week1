namespace Week1
{
    partial class Form19
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
            this.label1 = new System.Windows.Forms.Label();
            this.productPanel1 = new Week1.MyControls.ProductPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // productPanel1
            // 
            this.productPanel1.BackColor = System.Drawing.Color.Yellow;
            this.productPanel1.Description = "cdessce";
            this.productPanel1.Id = 0;
            this.productPanel1.ImageLinkText = "D:\\\\Image\\\\tick.png";
            this.productPanel1.Location = new System.Drawing.Point(50, 50);
            this.productPanel1.Name = "productPanel1";
            this.productPanel1.NameProduct = "Name";
            this.productPanel1.NormalButtonSize = new System.Drawing.Size(100, 50);
            this.productPanel1.NormalLocation = new System.Drawing.Point(50, 50);
            this.productPanel1.NormalSize = new System.Drawing.Size(300, 500);
            this.productPanel1.Price = 50000;
            this.productPanel1.Size = new System.Drawing.Size(300, 500);
            this.productPanel1.TabIndex = 0;
            this.productPanel1.ZoomButtonSize = new System.Drawing.Size(100, 50);
            this.productPanel1.ZoomSize = new System.Drawing.Size(350, 550);
            this.productPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.productPanel1_MouseDown);
            this.productPanel1.MouseEnter += new System.EventHandler(this.productPanel1_MouseEnter);
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 697);
            this.Controls.Add(this.productPanel1);
            this.Name = "Form19";
            this.Text = "20,30";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MyControls.ProductPanel productPanel1;
    }
}