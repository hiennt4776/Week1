namespace Week1
{
    partial class Form10
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
            this.btnCreatePanel = new System.Windows.Forms.Button();
            this.txtLocationX = new System.Windows.Forms.TextBox();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectPanel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletePanel = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreatePanel
            // 
            this.btnCreatePanel.Location = new System.Drawing.Point(12, 160);
            this.btnCreatePanel.Name = "btnCreatePanel";
            this.btnCreatePanel.Size = new System.Drawing.Size(105, 23);
            this.btnCreatePanel.TabIndex = 0;
            this.btnCreatePanel.Text = "Create Panel";
            this.btnCreatePanel.UseVisualStyleBackColor = true;
            this.btnCreatePanel.Click += new System.EventHandler(this.btnCreatePanel_Click);
            // 
            // txtLocationX
            // 
            this.txtLocationX.Location = new System.Drawing.Point(13, 25);
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.Size = new System.Drawing.Size(105, 20);
            this.txtLocationX.TabIndex = 1;
            // 
            // txtLocationY
            // 
            this.txtLocationY.Location = new System.Drawing.Point(13, 81);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Size = new System.Drawing.Size(105, 20);
            this.txtLocationY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // cmbSelectPanel
            // 
            this.cmbSelectPanel.FormattingEnabled = true;
            this.cmbSelectPanel.Location = new System.Drawing.Point(17, 359);
            this.cmbSelectPanel.Name = "cmbSelectPanel";
            this.cmbSelectPanel.Size = new System.Drawing.Size(105, 21);
            this.cmbSelectPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delete";
            // 
            // btnDeletePanel
            // 
            this.btnDeletePanel.Location = new System.Drawing.Point(17, 386);
            this.btnDeletePanel.Name = "btnDeletePanel";
            this.btnDeletePanel.Size = new System.Drawing.Size(105, 23);
            this.btnDeletePanel.TabIndex = 7;
            this.btnDeletePanel.Text = "Detele Panel";
            this.btnDeletePanel.UseVisualStyleBackColor = true;
            this.btnDeletePanel.Click += new System.EventHandler(this.btnDeletePanel_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(12, 133);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(107, 21);
            this.cmbColor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(17, 415);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(45, 234);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(59, 23);
            this.btnTop.TabIndex = 12;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(17, 263);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(47, 23);
            this.btnLeft.TabIndex = 13;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(75, 263);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(47, 23);
            this.btnRight.TabIndex = 14;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(45, 292);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(59, 23);
            this.btnBottom.TabIndex = 15;
            this.btnBottom.Text = "Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(17, 208);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 16;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.btnDeletePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSelectPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocationY);
            this.Controls.Add(this.txtLocationX);
            this.Controls.Add(this.btnCreatePanel);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePanel;
        private System.Windows.Forms.TextBox txtLocationX;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeletePanel;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.TextBox txtDistance;
    }
}