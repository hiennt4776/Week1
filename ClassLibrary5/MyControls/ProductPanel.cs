using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;


namespace ClassLibrary5.MyControls
{

    public class ProductPanel : Panel
    {
        private TableLayoutPanel tlpProduct;
        private PictureBox pcbImageProduct;

        private Panel pnlName;
        private Panel pnlDescription;
        private Panel pnlPrice;
        private Panel pnlAddCart;

        private Label lblDescription;

     
        private Label lblName;
        private Label lblPrice;
        private Button btnAddCart;

        private string imageLinkText;
        private string nameProduct;
        private string description;
        private int price;
        private int id;
        private Size normalSize = new Size();
        private Size normalButtonSize = new Size();
        private Size normalZoomSize = new Size();

        private Size zoomButtonSize = new Size();
        private Size zoomSize = new Size();

        private bool ZoomStatic = false;
        private bool MoveStatic = false;
        private int locationX = 0;
        private int locationY = 0;
        private int first = 0;
        private int last = 0;
        private Point normalLocation = new Point();
        public event EventHandler MoveDirection;
        /*
         
         
         */



        public ProductPanel()
        {

            InitializeControls();
           

        }

        private void InitializeControls()
        {
            BackColor = Color.Yellow;
            Size = normalSize;
            Location = normalLocation;
            MouseDown += ProductPanel_MouseDown;
            MouseLeave += ProductPanel_MouseLeave;
            MouseUp += ProductPanel_MouseUp;
            LocationChanged += ProductPanel_LocationChanged;
            locationX = Location.X;
            locationY = Location.Y;

            tlpProduct = new TableLayoutPanel();
            tlpProduct.Size = normalSize;
            tlpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
     | System.Windows.Forms.AnchorStyles.Left)
     | System.Windows.Forms.AnchorStyles.Right)));
            tlpProduct.ColumnCount = 1;
            tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpProduct.Name = "tlpProduct";
            tlpProduct.RowCount = 5;
            tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tlpProduct.TabIndex = 0;
            tlpProduct.BackColor = System.Drawing.Color.Red;
            tlpProduct.MouseDown += ProductPanel_MouseDown;
            tlpProduct.MouseLeave += ProductPanel_MouseLeave;
            tlpProduct.MouseUp += ProductPanel_MouseUp;
            Controls.Add(tlpProduct);

            pcbImageProduct = new PictureBox();
            pcbImageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
   
            pcbImageProduct.Name = "pcbImageProduct";
            pcbImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcbImageProduct.TabIndex = 0;
            pcbImageProduct.TabStop = false;
            pcbImageProduct.BackColor = Color.Pink;
            //pcbImageProduct.Image = System.Drawing.Image.FromFile("D:\\Image\\tick.png");
            pcbImageProduct.MouseDown += ProductPanel_MouseDown;
            pcbImageProduct.MouseLeave += ProductPanel_MouseLeave;
            pcbImageProduct.MouseUp += ProductPanel_MouseUp;
            tlpProduct.Controls.Add(pcbImageProduct, 0, 0);


            pnlName = new Panel();
            pnlName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
            pnlName.Controls.Add(lblDescription);
        
            pnlName.Name = "pnlName";
            pnlName.TabIndex = 1;
            pnlName.BackColor = Color.Orange;
            pnlName.MouseDown += ProductPanel_MouseDown;
            pnlName.MouseLeave += ProductPanel_MouseLeave;
            pnlName.MouseUp += ProductPanel_MouseUp;
            tlpProduct.Controls.Add(pnlName, 0, 1);

            lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            lblName.TabIndex = 0;
            lblName.Text = "Product 1";
            lblName.MouseDown += ProductPanel_MouseDown;
            lblName.MouseLeave += ProductPanel_MouseLeave;
            lblName.MouseUp += ProductPanel_MouseUp;
            pnlName.Controls.Add(lblName);



            pnlDescription = new Panel();
            pnlDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
            pnlDescription.Controls.Add(lblDescription);

            pnlDescription.Name = "pnlDescription";

            pnlDescription.TabIndex = 1;
            pnlDescription.BackColor = Color.Yellow;
            pnlDescription.MouseDown += ProductPanel_MouseDown;
            pnlDescription.MouseLeave += ProductPanel_MouseLeave;
            pnlDescription.MouseUp += ProductPanel_MouseUp;
            tlpProduct.Controls.Add(pnlDescription, 0, 2);

         

            lblDescription = new Label();
            lblDescription.Location = new Point(0, 0);
            lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
       | System.Windows.Forms.AnchorStyles.Left)
       | System.Windows.Forms.AnchorStyles.Right)));
            lblDescription.Text = "Nam in justo vel tortor faucibus rutrum vel sit amet risus. Nam tortor nisl, pharetra eu scelerisque nec, congue sit amet nibh. Aliquam sem purus, consectetur vitae orci sed, placerat pellentesque turpis. Praesent at bibendum urna, euismod consectetur nibh. Aliquam in ullamcorper arcu. Nam vehicula, enim id maximus dictum, nunc libero hendrerit velit, vel condimentum neque diam vel dui. Aliquam auctor sollicitudin augue, et volutpat elit tincidunt vel. Aliquam id erat vitae elit congue rutrum.";
            lblDescription.Size = pnlDescription.Size;
            lblDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            lblDescription.AllowDrop = true;
            lblDescription.MouseDown += ProductPanel_MouseDown;
            lblDescription.MouseLeave += ProductPanel_MouseLeave;
            lblDescription.MouseUp += ProductPanel_MouseUp;
            pnlDescription.Controls.Add(lblDescription);
            
            
            pnlPrice = new Panel();

            pnlPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
            pnlPrice.Name = "pnlPrice";
            pnlPrice.TabIndex = 1;
            pnlPrice.BackColor = Color.Blue;
            pnlPrice.MouseDown += ProductPanel_MouseDown;
            pnlPrice.MouseLeave += ProductPanel_MouseLeave;
            pnlPrice.MouseUp += ProductPanel_MouseUp;
            tlpProduct.Controls.Add(pnlPrice, 0, 3);

            lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrice.TabIndex = 0;
            lblPrice.Text = "35000";
            lblPrice.MouseDown += ProductPanel_MouseDown;
            lblPrice.MouseLeave += ProductPanel_MouseLeave;
            lblPrice.MouseUp += ProductPanel_MouseUp;
            pnlPrice.Controls.Add(lblPrice);


            pnlAddCart = new Panel();
            pnlAddCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
            pnlAddCart.Controls.Add(btnAddCart);
       
            pnlAddCart.Name = "pnlAddCart";
         
            pnlAddCart.BackColor = Color.Green;


            pnlAddCart.MouseDown += ProductPanel_MouseDown;
            pnlAddCart.MouseLeave += ProductPanel_MouseLeave;
            pnlAddCart.MouseUp += ProductPanel_MouseUp;

            tlpProduct.Controls.Add(pnlAddCart, 0, 4);

            btnAddCart = new Button();
         
            btnAddCart.Size = normalButtonSize;

    
            btnAddCart.Location = new Point(
                  (pnlAddCart.Width - btnAddCart.Width) / 2,
                  (pnlAddCart.Height - btnAddCart.Height) / 2
              );

            btnAddCart.Name = "btnAddCart";
           
            btnAddCart.TabIndex = 0;
            btnAddCart.Text = "Add Cart";
            btnAddCart.UseVisualStyleBackColor = true;

            btnAddCart.Click += BtnAddCart_Click;

            pnlAddCart.Controls.Add(btnAddCart);

            //Controls.Add(lblDescription);


        }


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The size of the label within the YellowPanel.")]
        [Category("SetNew")]
        public Size ZoomSize
        {
            get { return zoomSize; }
            set
            {
                zoomSize = value;
               
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The location of the label within the YellowPanel.")]
        [Category("SetNew")]
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
        [Description("The size of the label within the YellowPanel.")]
        [Category("SetNew")]
        public Size NormalSize
        {
            get { return normalSize; }
            set
            {
                normalSize = value;
                Size = normalSize;
                btnAddCart.Location = new Point(
                 (pnlAddCart.Width - btnAddCart.Width) / 2,
                 (pnlAddCart.Height - btnAddCart.Height) / 2
             );
            }
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The size of the label within the YellowPanel.")]
        [Category("SetNew")]
        public Size NormalButtonSize
        {
            get { return normalButtonSize; }
            set
            {
                normalButtonSize = value;
                btnAddCart.Size = normalButtonSize;
                btnAddCart.Location = new Point(
                 (pnlAddCart.Width - btnAddCart.Width) / 2,
                 (pnlAddCart.Height - btnAddCart.Height) / 2);


            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The size of the label within the YellowPanel.")]
        [Category("SetNew")]
        public Size ZoomButtonSize
        {
            get { return zoomButtonSize; }
            set
            {
              zoomButtonSize = value;
          
            }
        }


        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The text of the label.")]
        [Category("SetNew")]
        public string ImageLinkText
        {
            get { return imageLinkText; }
            set { imageLinkText = value;
                pcbImageProduct.Image = System.Drawing.Image.FromFile(imageLinkText);
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The text of the label.")]
        [Category("SetNew")]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
               
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The text of the label.")]
        [Category("SetNew")]
        public string NameProduct
        {
            get { return nameProduct; }
            set
            {
                nameProduct = value;
                lblName.Text = nameProduct;
            }
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The text of the label.")]
        [Category("SetNew")]
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                lblPrice.Text = price.ToString();
            }
        }



        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("The text of the label.")]
        [Category("SetNew")]
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                lblDescription.Text = description;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Occurs when Add Cart is clicked.")]
        public event EventHandler BtnAddCartClick;

        protected virtual void OnBtnAddCartClick(EventArgs e)
        {
            BtnAddCartClick?.Invoke(this, e);
        }

        private void BtnAddCart_Click(object sender, EventArgs e)
        {
            // Raise the Button3Click event
            ZoomStatic = true;
            int x = NormalLocation.X - (ZoomSize.Width - normalSize.Width) / 2;
            int y = NormalLocation.Y - (ZoomSize.Height - normalSize.Height) / 2;
            Location = new Point(NormalLocation.X - (ZoomSize.Width - normalSize.Width) / 2, NormalLocation.Y - (ZoomSize.Height - normalSize.Height) / 2);
            Size = ZoomSize;
            btnAddCart.Size = zoomButtonSize;
            btnAddCart.Location = new Point(
                 (pnlAddCart.Width - btnAddCart.Width) / 2,
                 (pnlAddCart.Height - btnAddCart.Height) / 2
             );

            OnBtnAddCartClick(EventArgs.Empty);
        }

        public int First
        {
            get { return first; }
            set
            {
                first = value;
               
            }
        }

        public int Last
        {
            get { return last; }
            set
            {
                last = value;

            }
        }
        private void ProductPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ZoomStatic = true;
                int x = NormalLocation.X - (ZoomSize.Width - normalSize.Width) / 2;
                int y = NormalLocation.Y - (ZoomSize.Height - normalSize.Height) / 2;
                Location = new Point(NormalLocation.X - (ZoomSize.Width - normalSize.Width) / 2, NormalLocation.Y - (ZoomSize.Height - normalSize.Height) / 2);
                Size = ZoomSize;
                btnAddCart.Size = zoomButtonSize;
                btnAddCart.Location = new Point(
                 (pnlAddCart.Width - btnAddCart.Width) / 2,
                 (pnlAddCart.Height - btnAddCart.Height) / 2
                );
            }

            if (e.Button == MouseButtons.Left)
            {
                First = e.X;
                //labelPosition1.Text = First.ToString();

            }
        }

        private void ProductPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //lblDescription.Text = "MouseLeave";
                ZoomStatic = false;
            int x = NormalLocation.X + (ZoomSize.Width - normalSize.Width) / 2;
            int y = NormalLocation.Y + (ZoomSize.Height - normalSize.Height) / 2;
            Location = normalLocation;
            Size = normalSize;
            btnAddCart.Size = normalButtonSize;
            btnAddCart.Location = new Point(
                 (pnlAddCart.Width - btnAddCart.Width) / 2,
                 (pnlAddCart.Height - btnAddCart.Height) / 2
            );
                }

            if (e.Button == MouseButtons.Left)
            {
                last = e.X;
                //labelPosition2.Text = Last.ToString();
                //if (first > last)
                //{

                //    MessageBox.Show("First > Last");
                //};
                //if (first < last)
                //{
                //    MessageBox.Show("First < Last");

                //}
                MoveDirection?.Invoke(this, EventArgs.Empty);
            }



        }

        private void ProductPanel_MouseLeave(object sender, EventArgs e)
        {
     
            if (!ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                //lblDescription.Text = "MouseLeave";
                ZoomStatic = false;
                int x = NormalLocation.X + (ZoomSize.Width - normalSize.Width) / 2;
                int y = NormalLocation.Y + (ZoomSize.Height - normalSize.Height) / 2;
                Location = normalLocation;
                Size = normalSize;
                btnAddCart.Size = normalButtonSize;
                btnAddCart.Location = new Point(
                     (pnlAddCart.Width - btnAddCart.Width) / 2,
                     (pnlAddCart.Height - btnAddCart.Height) / 2
                );
              
            }

           
        }

        private void ProductPanel_LocationChanged(object sender, EventArgs e)
        {
            if (!ZoomStatic)
            {
                normalLocation = Location;
            }
            
        }

       



    }
}
