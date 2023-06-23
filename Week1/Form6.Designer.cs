namespace Week1
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.childPanel = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.childPanel2 = new System.Windows.Forms.Panel();
            this.parentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(12, 397);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.Text = "LeftButton";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            this.LeftButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LeftButton_MouseClick);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(93, 397);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 23);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "RightButton";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.childPanel2);
            this.parentPanel.Controls.Add(this.childPanel);
            this.parentPanel.Location = new System.Drawing.Point(114, 78);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(448, 182);
            this.parentPanel.TabIndex = 2;
            // 
            // childPanel
            // 
            this.childPanel.BackColor = System.Drawing.Color.Red;
            this.childPanel.Location = new System.Drawing.Point(-50, 48);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(200, 100);
            this.childPanel.TabIndex = 0;
            this.childPanel.MouseCaptureChanged += new System.EventHandler(this.childPanel_MouseCaptureChanged);
            this.childPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.childPanel_MouseDown);
            this.childPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.childPanel_MouseMove);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(133, 282);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "label1";
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(13, 350);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(75, 23);
            this.btnIncrease.TabIndex = 4;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(95, 350);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(75, 23);
            this.btnDecrease.TabIndex = 5;
            this.btnDecrease.Text = "Decrease";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // childPanel2
            // 
            this.childPanel2.BackColor = System.Drawing.Color.DarkOrange;
            this.childPanel2.Location = new System.Drawing.Point(206, 48);
            this.childPanel2.Name = "childPanel2";
            this.childPanel2.Size = new System.Drawing.Size(200, 100);
            this.childPanel2.TabIndex = 1;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.parentPanel);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Name = "Form6";
            this.Text = "Form6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.parentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel childPanel2;
    }
}