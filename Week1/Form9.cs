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
    public partial class Form9 : Form
    {
        private List<Product> productList;
        private int panelCount = 0;
        private Dictionary<int, Panel> panels = new Dictionary<int, Panel>();
        private Panel parentPanel;
        private Panel productPanel;



        const int LocationParentPanelX = 80;
        const int LocationParentPanelY = 30;
        const int SizeParentPanelX = 1200;
        const int SizeParentPanelY = 600;



        const int LocationProductY = 50;

        const int distanceMove = SizeParentPanelX / 3;

        const int SizeProductPanelX = 300;
        const int SizeProductPanelY = 500;
        const int distancePanel = distanceMove - SizeProductPanelX;
        const int halfDistancePanel = distancePanel / 2;

        const int LocationProductCenterX = SizeProductPanelX + distancePanel + halfDistancePanel;
        //const int LocationProductCenterY = 50;

        const int LocationProductLeftX = halfDistancePanel;
        //const int LocationProductLeftY = 50;

        const int LocationProductRightX = 2*SizeProductPanelX + 2*distancePanel + halfDistancePanel;
       //const int LocationProductRightY = 50;

        const int LocationProductPreview = 0 - halfDistancePanel - SizeProductPanelX;
        //const int LocationProductLeftY = 50;

        const int LocationProductNext = SizeParentPanelX + halfDistancePanel;
        //const int LocationProductLeftY = 50;

        const int zoomDistancePanelX = 50;
        const int zoomDistancePanelY = 50;

        public Form9()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            productList = new List<Product>();
            productList.Add(new Product(1, "Product 1", "image1.jpg", "Description 1", 10.99));
            productList.Add(new Product(2, "Product 2", "image2.jpg", "Description 2", 19.99));
            productList.Add(new Product(3, "Product 3", "image3.jpg", "Description 3", 5.99));
            productList.Add(new Product(4, "Product 4", "image4.jpg", "Description 4", 8.99));
            productList.Add(new Product(5, "Product 5", "image5.jpg", "Description 5", 14.99));
            productList.Add(new Product(6, "Product 6", "image6.jpg", "Description 6", 12.99));
            productList.Add(new Product(7, "Product 7", "image7.jpg", "Description 7", 9.99));
            productList.Add(new Product(8, "Product 8", "image8.jpg", "Description 8", 7.99));
            productList.Add(new Product(9, "Product 9", "image9.jpg", "Description 9", 11.99));
            productList.Add(new Product(10, "Product 10", "image10.jpg", "Description 10", 16.99));


            CreateParentPanel();
            CreatePreviewProductPanel();
            CreateLeftProductPanel();
            
            CreateCenterProductPanel();
            CreateRightProductPanel();
            CreateNextProductPanel();
        }

        private void CreateParentPanel()
        {
            parentPanel = new Panel();
            parentPanel.Location = new System.Drawing.Point(LocationParentPanelX, LocationParentPanelY);
            parentPanel.Name = "panelParent";
            parentPanel.Size = new System.Drawing.Size(SizeParentPanelX, SizeParentPanelY);
            parentPanel.BackColor = System.Drawing.Color.Yellow;
            Controls.Add(parentPanel);
        }
        private void CreatePreviewProductPanel()
        {
            productPanel = new Panel();
            productPanel.Location = new System.Drawing.Point(LocationProductPreview, LocationProductY);
            productPanel.Name = "panelProduct1";
            productPanel.Size = new System.Drawing.Size(SizeProductPanelX, SizeProductPanelY);
            productPanel.BackColor = System.Drawing.Color.Blue;
            parentPanel.Controls.Add(productPanel);
        }
        private void CreateLeftProductPanel()
        {
            productPanel = new Panel();
            productPanel.Location = new System.Drawing.Point(LocationProductLeftX, LocationProductY);
            productPanel.Name = "panelProduct1";
            productPanel.Size = new System.Drawing.Size(SizeProductPanelX, SizeProductPanelY);
            productPanel.BackColor = System.Drawing.Color.Blue;
            parentPanel.Controls.Add(productPanel);
        }
        private void CreateCenterProductPanel()
        {
            productPanel = new Panel();
            productPanel.Location = new System.Drawing.Point(LocationProductCenterX, LocationProductY);
            productPanel.Name = "panelProduct1";
            productPanel.Size = new System.Drawing.Size(SizeProductPanelX, SizeProductPanelY);
            productPanel.BackColor = System.Drawing.Color.Red;
            parentPanel.Controls.Add(productPanel);
        }

        private void CreateRightProductPanel()
        {
            productPanel = new Panel();
            productPanel.Location = new System.Drawing.Point(LocationProductRightX, LocationProductY);
            productPanel.Name = "panelProduct1";
            productPanel.Size = new System.Drawing.Size(SizeProductPanelX, SizeProductPanelY);
            productPanel.BackColor = System.Drawing.Color.Green;
            parentPanel.Controls.Add(productPanel);
        }
        private void CreateNextProductPanel()
        {
            productPanel = new Panel();
            productPanel.Location = new System.Drawing.Point(LocationProductNext, LocationProductY);
            productPanel.Name = "panelProduct1";
            productPanel.Size = new System.Drawing.Size(SizeProductPanelX, SizeProductPanelY);
            productPanel.BackColor = System.Drawing.Color.Green;
            parentPanel.Controls.Add(productPanel);
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            int formWidth = this.Width;    // Width of the form
            int formHeight = this.Height;  // Height of the form
           //MessageBox.Show("form Width = " + formWidth + ", form Height = " + formHeight);



        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
