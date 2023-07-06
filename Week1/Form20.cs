using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week1.MyControls;

namespace Week1
{
    public partial class Form20 : Form
    {
        private List<Product> productList = new List<Product>();
        public Form20()
        {
            InitializeComponent();
            CreateListProduct();
            LoadProduct();
      

        }

        public void LoadProduct()
        {
            Point pointLocation = new Point(50,100);
            Size normalSize = new Size(300, 500);
            Size zoomSize = new Size(350, 550);
            Size zoomButtonSize = new Size(125, 30);
            Size normalButtonSize = new Size(100, 25);


            

            foreach (Product product in productList)
            {
                ProductPanel productPanel = new ProductPanel();
                productPanel.Location = pointLocation;
        
                productPanel.NormalSize = normalSize;
                productPanel.NormalLocation = pointLocation;
                productPanel.ZoomSize = zoomSize;
                productPanel.ZoomButtonSize = zoomButtonSize;
                productPanel.NormalButtonSize = normalButtonSize;

                productPanel.Id = product.Id;
                productPanel.NameProduct = product.Name;
                productPanel.ImageLinkText = product.LinkPicture;
                productPanel.Price = product.Price;
                productPanel.Description = product.Description;
                productPanel.BtnAddCartClick += ProductPanel_BtnAddCartClick;

                productPanel.MoveDirection += productPanel_MoveDirection;

               
                carouselPanel.Controls.Add(productPanel);
                pointLocation.X += 400;
            }
        }

        private void productPanel_MoveDirection(object sender, EventArgs e)
        {
            ProductPanel productPanel = sender as ProductPanel;
            if (productPanel.First > productPanel.Last)
            {
                NextA();
            }
            if (productPanel.First < productPanel.Last)
            {
                BackA();
            }
        }

        private void ProductPanel_BtnAddCartClick(object sender, EventArgs e)
        {
            // Get the YellowPanel instance where the button was clicked
            ProductPanel productPanel = sender as ProductPanel;

            // Access the label in the YellowPane update its text
            lblProduct.Text = productPanel.NameProduct;
            lblPrice.Text = productPanel.Price.ToString();
            lblId.Text = productPanel.Id.ToString();
        }
        public void CreateListProduct()
        {
            // Add 10 products to the list
            for (int i = 1; i <= 10; i++)
            {
                Product product = new Product();
                product.Id = i;
                product.Name = "Product Name " + i.ToString();
                product.LinkPicture = "D:\\Image\\tick.png";
                product.Price = i * 1000;
                product.Description = "Donec porta bibendum dignissim. Aliquam quis commodo mauris, non malesuada arcu. Quisque sed feugiat ante. Sed at bibendum enim. Suspendisse pharetra ullamcorper nisi, sed fringilla metus porta vel. Mauris non nisi at diam commodo sollicitudin. Duis placerat velit rutrum lobortis maximus. Praesent non orci vestibulum leo condimentum mollis. ";
                productList.Add(product);
            }  
        }

        public class Product
        {
            public int Id { get; set; }
            public string LinkPicture { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
        }

     

     
        private void BackA()
        {
            CarouselPanel carouselPanel = Controls.Find("carouselPanel", true).FirstOrDefault() as CarouselPanel;

            // Call the CustomMethod in the YellowPanel
            carouselPanel?.Back();
        }

        private void NextA()
        {
            // Find the YellowPanel control on the form
            CarouselPanel carouselPanel = Controls.Find("carouselPanel", true).FirstOrDefault() as CarouselPanel;

            // Call the CustomMethod in the YellowPanel
            carouselPanel?.Next();
        }


    }
}
