using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form14 : Form
    {
        private const int PanelMoveDistanceAfterSleep = 2;
        private const int SizeParentPanelX = 1200;
        private const int SizeParentPanelY = 600;
        private const int LocationParentPanelX = 80;
        private const int LocationParentPanelY = 30;
        private const int SizeProductPanelX = 300;
        private const int SizeProductPanelY = 500;
        private const int LocationProductY = 50;
        private const int distanceMove = SizeParentPanelX / 3;
        private const int maxFor = distanceMove / PanelMoveDistanceAfterSleep;
        private const int distancePanel = distanceMove - SizeProductPanelX;
        private const int halfDistancePanel = distancePanel / 2;
        private const int LocationProductCenterX = SizeProductPanelX + distancePanel + halfDistancePanel;
        private const int LocationProductLeftX = halfDistancePanel;
        private const int LocationProductRightX = 2 * SizeProductPanelX + 2 * distancePanel + halfDistancePanel;
        private const int LocationProductPreview = 0 - halfDistancePanel - SizeProductPanelX;
        private const int LocationProductNext = SizeParentPanelX + halfDistancePanel;
        private const int zoomDistancePanelX = 25;
        private const int zoomDistancePanelY = 25;

        private Thread thread = new Thread(() => { });
        private Panel parentPanel;
        private List<Product> productList;
        public Form14()
        {
            InitializeComponent();

            productList = GenerateProductList();
            CreateParentPanel();
        }
        private List<Product> GenerateProductList()
        {
            var products = new List<Product>();

            // Add 10 products to the list
            for (int i = 1; i <= 10; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Price = i * 10.0m
                };
                products.Add(product);
            }

            return products;
        }

        private void CreateProductPanel(Panel parentPanel, int locationX, string panelName, Color panelColor, Product product)
        {
            var productPanel = new Panel
            {
                Location = new Point(locationX, LocationProductY),
                Name = panelName,
                Size = new Size(SizeProductPanelX, SizeProductPanelY),
                BackColor = panelColor
            };

            var idLabel = new Label
            {
                Text = $"ID: {product.Id}",
                Location = new Point(10, 10),
                AutoSize = true
            };
            productPanel.Controls.Add(idLabel);

            var nameLabel = new Label
            {
                Text = $"Name: {product.Name}",
                Location = new Point(10, 30),
                AutoSize = true
            };
            productPanel.Controls.Add(nameLabel);

            var priceLabel = new Label
            {
                Text = $"Price: {product.Price}",
                Location = new Point(10, 50),
                AutoSize = true
            };
            productPanel.Controls.Add(priceLabel);

            productPanel.MouseEnter += (sender, e) =>
            {
                productPanel.Size = new Size(SizeProductPanelX + zoomDistancePanelX, SizeProductPanelY + zoomDistancePanelY);
            };

            productPanel.MouseLeave += (sender, e) =>
            {
                productPanel.Size = new Size(SizeProductPanelX, SizeProductPanelY);
            };

            parentPanel.Controls.Add(productPanel);
        }

        private void CreateParentPanel()
        {
            parentPanel = new Panel
            {
                Location = new Point(LocationParentPanelX, LocationParentPanelY),
                Name = "panelParent",
                Size = new Size(SizeParentPanelX, SizeParentPanelY),
                BackColor = Color.Yellow
            };
            Controls.Add(parentPanel);

            for (int i = 0; i < productList.Count; i++)
            {
                var product = productList[i];
                int locationX;
                if (i == 0)
                    locationX = LocationProductPreview;
                else if (i == 1)
                    locationX = LocationProductLeftX;
                else if (i == 2)
                    locationX = LocationProductCenterX;
                else if (i == 3)
                    locationX = LocationProductRightX;
                else if (i == 4)
                    locationX = LocationProductNext;
                else
                    locationX = 0;

                CreateProductPanel(parentPanel, locationX, $"panelProduct{i + 1}", Color.Blue, product);
            }
        }

        private void MovePanels(int distance)
        {
            thread.Abort();
            thread = new Thread(() =>
            {
                for (int j = 0; j < maxFor; j++)
                {
                    Thread.Sleep(0);
                    BeginInvoke(new Action(() =>
                    {
                        foreach (Control control in parentPanel.Controls)
                        {
                            if (control is Panel panel)
                            {
                                panel.Left += distance;
                            }
                        }
                    }));
                }
            });
            thread.Start();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            MovePanels(-PanelMoveDistanceAfterSleep);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MovePanels(PanelMoveDistanceAfterSleep);
        }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

    }
}
