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
    public partial class Form8 : Form
    {
        private List<Product> productList;
        public Form8()
        {
            InitializeComponent();
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


            LoadProductPanels();
        }

     

        private void LoadProductPanels()
        {
            int YPoint = 10;
          
            foreach (Product product in productList)
            {
                Point PanelPoint = new Point(10, YPoint);
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Width = parentPanel.Width - 20;
                panel.Height = parentPanel.Height - 200;
                panel.Location = PanelPoint;
                YPoint += 200;
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = product.LinkOfImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.Location = new Point(10, 10);

                Label nameLabel = new Label();
                nameLabel.Text = product.Name;
                nameLabel.Location = new Point(120, 10);
                nameLabel.AutoSize = true;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = product.Description;
                descriptionLabel.Location = new Point(120, 30);
                descriptionLabel.AutoSize = true;

                Label priceLabel = new Label();
                priceLabel.Text = "Price: $" + product.Price.ToString("0.00");
                priceLabel.Location = new Point(120, 60);
                priceLabel.AutoSize = true;
                priceLabel.MouseEnter += PriceLavel_MouseEnter; 

                Button button = new Button();
                button.Text = "Show ID";
                button.Location = new Point(120, 90);
                button.Tag = product.Id; // Store the product ID in the button's Tag property
                button.Click += Button_Click;

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(descriptionLabel);
                panel.Controls.Add(priceLabel);
                panel.Controls.Add(button);

                parentPanel.Controls.Add(panel);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int productId = (int)button.Tag; // Retrieve the product ID from the button's Tag property
            lblProductId.Text = "Product ID: " + productId.ToString();
        }

        private void PriceLavel_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Red;
        }

    }
}
