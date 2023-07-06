namespace Week1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.tlpProduct1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAddCart = new System.Windows.Forms.Panel();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.pcbImageProduct = new System.Windows.Forms.PictureBox();
            this.pnlDescriptionProduct = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDescription.SuspendLayout();
            this.tlpProduct1.SuspendLayout();
            this.pnlAddCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageProduct)).BeginInit();
            this.pnlDescriptionProduct.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlDescription.Controls.Add(this.tlpProduct1);
            this.pnlDescription.Location = new System.Drawing.Point(38, 22);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(1200, 600);
            this.pnlDescription.TabIndex = 0;
            // 
            // tlpProduct1
            // 
            this.tlpProduct1.BackColor = System.Drawing.Color.Red;
            this.tlpProduct1.ColumnCount = 1;
            this.tlpProduct1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProduct1.Controls.Add(this.pnlAddCart, 0, 3);
            this.tlpProduct1.Controls.Add(this.pcbImageProduct, 0, 0);
            this.tlpProduct1.Controls.Add(this.pnlDescriptionProduct, 0, 1);
            this.tlpProduct1.Controls.Add(this.pnlPrice, 0, 2);
            this.tlpProduct1.Location = new System.Drawing.Point(50, 50);
            this.tlpProduct1.Name = "tlpProduct1";
            this.tlpProduct1.RowCount = 4;
            this.tlpProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpProduct1.Size = new System.Drawing.Size(300, 500);
            this.tlpProduct1.TabIndex = 3;
            this.tlpProduct1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.tlpProduct1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            this.tlpProduct1.MouseHover += new System.EventHandler(this.tableLayoutPanel1_MouseHover);
            // 
            // pnlAddCart
            // 
            this.pnlAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddCart.Controls.Add(this.btnAddCart);
            this.pnlAddCart.Location = new System.Drawing.Point(3, 463);
            this.pnlAddCart.Name = "pnlAddCart";
            this.pnlAddCart.Size = new System.Drawing.Size(294, 34);
            this.pnlAddCart.TabIndex = 2;
            this.pnlAddCart.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            this.pnlAddCart.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCart.AutoSize = true;
            this.btnAddCart.Location = new System.Drawing.Point(114, 3);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(75, 28);
            this.btnAddCart.TabIndex = 0;
            this.btnAddCart.Text = "Add Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // pcbImageProduct
            // 
            this.pcbImageProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImageProduct.Image = global::Week1.Properties.Resources.Screenshot__2_;
            this.pcbImageProduct.Location = new System.Drawing.Point(3, 3);
            this.pcbImageProduct.Name = "pcbImageProduct";
            this.pcbImageProduct.Size = new System.Drawing.Size(294, 294);
            this.pcbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImageProduct.TabIndex = 0;
            this.pcbImageProduct.TabStop = false;
            this.pcbImageProduct.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pcbImageProduct.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pnlDescriptionProduct
            // 
            this.pnlDescriptionProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescriptionProduct.Controls.Add(this.lblDescription);
            this.pnlDescriptionProduct.Location = new System.Drawing.Point(3, 303);
            this.pnlDescriptionProduct.Name = "pnlDescriptionProduct";
            this.pnlDescriptionProduct.Size = new System.Drawing.Size(294, 119);
            this.pnlDescriptionProduct.TabIndex = 1;
            this.pnlDescriptionProduct.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.pnlDescriptionProduct.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(288, 119);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblDescription.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.label1);
            this.pnlPrice.Location = new System.Drawing.Point(3, 428);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(294, 29);
            this.pnlPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price: 1000";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pnlDescription);
            this.Name = "Form11";
            this.Text = "Form11";
            this.pnlDescription.ResumeLayout(false);
            this.tlpProduct1.ResumeLayout(false);
            this.pnlAddCart.ResumeLayout(false);
            this.pnlAddCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageProduct)).EndInit();
            this.pnlDescriptionProduct.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.TableLayoutPanel tlpProduct1;
        private System.Windows.Forms.PictureBox pcbImageProduct;
        private System.Windows.Forms.Panel pnlDescriptionProduct;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddCart;
        private System.Windows.Forms.Button btnAddCart;
    }
}