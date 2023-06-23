using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Week1.Form14;
using static Week1.Form15;
using Timer = System.Windows.Forms.Timer;

namespace Week1
{
    public partial class Form15 : Form
    {
        private const int PanelMoveDistanceAfterSleep = 4;
        private const int TimerSleep = 1;
        private const int SizeParentPanelX = 1200;
        private const int SizeParentPanelY = 600;
        private const int LocationParentPanelX = 100;
        private const int LocationParentPanelY = 60;
        private const int SizeProductPanelX = 300;
        private const int SizeProductPanelY = 500;
        private const int LocationProductY = 50;
        private const int distanceMove = SizeParentPanelX / 3;
        private const int maxFor = distanceMove / PanelMoveDistanceAfterSleep; //phai chia het
        private const int distancePanel = distanceMove - SizeProductPanelX;
        private const int halfDistancePanel = distancePanel / 2;
        private const int LocationProductCenterX = SizeProductPanelX + distancePanel + halfDistancePanel;
        private const int LocationProductLeftX = halfDistancePanel;
        private const int LocationProductRightX = 2 * SizeProductPanelX + 2 * distancePanel + halfDistancePanel;
        private const int LocationProductPreviewX = 0 - halfDistancePanel - SizeProductPanelX;
        private const int LocationProductNextX = SizeParentPanelX + halfDistancePanel;
        private const int zoomDistancePanelX = 50;
        private const int zoomDistancePanelY = 50;

        private const int zoomDistanceButtonX = 10;
        private const int zoomDistanceButtonY = 10;

        private static Timer aTimer;


        private Thread thread = new Thread(() => { });
        private Panel parentPanel;
        private List<Product> productList;
       
        private int previewProduct;
    
        private int nextProduct;
        public Form15()
        {
            InitializeComponent();

            productList = GenerateProductList();

            previewProduct = 0;
         
            nextProduct = 2;

            //lblPreview.Text = previewProduct.ToString();
     
            //lblNext.Text = nextProduct.ToString();

            CreateParentPanel();
            CreateFirstProductPanel();
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
            //lblCreateProduct.Text = product.Id.ToString();
        productPanel.Controls.Add(nameLabel);

        var priceLabel = new Label
        {
            Text = $"Price: {product.Price}",
            Location = new Point(10, 50),
            AutoSize = true
        };
        productPanel.Controls.Add(priceLabel);

       var panelnameLabel = new Label
            {
                Text = $"Label: {productPanel.Name}",
                Location = new Point(10, 60),
                AutoSize = true
            };
            productPanel.Controls.Add(panelnameLabel);

            productPanel.MouseEnter += (sender, e) =>
            {   
                if(productPanel.Width == SizeProductPanelX)
                {
                    productPanel.Location = new Point(productPanel.Location.X - zoomDistancePanelX/2, productPanel.Location.Y - zoomDistancePanelY/2);

                    productPanel.Size = new Size(SizeProductPanelX + zoomDistancePanelX, SizeProductPanelY + zoomDistancePanelY);
                }
             
            };

        productPanel.MouseLeave += (sender, e) =>
        {
            if (productPanel.Width != SizeProductPanelX)
            {
                productPanel.Location = new Point(productPanel.Location.X + zoomDistancePanelX / 2, productPanel.Location.Y + zoomDistancePanelY / 2);

                productPanel.Size = new Size(SizeProductPanelX, SizeProductPanelY);
            }

           
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

        }

        private void CreateFirstProductPanel()
        {
            for (int i = 0; i < 3; i++)
            {
                var product = productList[i];
                int locationX;
                if (i == 0)
                    locationX = LocationProductLeftX;
                else if (i == 1)
                    locationX = LocationProductCenterX;
                else
                    locationX = LocationProductRightX;
 
                CreateProductPanel(parentPanel, locationX, $"panelProduct{i}", Color.Blue, product);
            }
        }

    private void MovePanels(int distance)
        {

            if (thread == null || !thread.IsAlive)
            {
                thread = new Thread(() =>
                {
                    for (int j = 0; j < maxFor; j++)
                    {
                        Thread.Sleep(TimerSleep);
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


          
           


        }
        private int countPanel()
        {
            int count = 0;
            foreach (Control control in parentPanel.Controls)
            {
                if (control is Panel panel)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnPreview_Click(object sender, EventArgs e)
         {
            if (thread == null || !thread.IsAlive)
            {
                int k = previewProduct;

                previewProduct--;
                if (previewProduct < 0)
                {
                    previewProduct = productList.Count - 1;
                }

                nextProduct--;
                if (nextProduct < 0)
                {
                    nextProduct = productList.Count - 1;
                }


                var product = productList[previewProduct];
                CreateProductPanel(parentPanel, LocationProductPreviewX, $"panelProduct{previewProduct}", Color.Blue, product);
         

                RemovePanel();

                //MovePanels(PanelMoveDistanceAfterSleep);
                thread = new Thread(() =>
                {
                    for (int j = 0; j < maxFor; j++)
                    {
                        Thread.Sleep(TimerSleep);
                        BeginInvoke(new Action(()=>
                        {
                            foreach (Control control in parentPanel.Controls)
                            {
                                if (control is Panel panel)
                                {
                                    panel.Left += PanelMoveDistanceAfterSleep;
                                }
                            }
                        }));
                    }
                 
                });
                thread.Start();
                k = previewProduct;
                RemovePanel();
                //lblCountPanel.Text = countPanel().ToString();

            }

           
        }

        private void RemovePanel()
        {
            foreach (Control control in parentPanel.Controls)
            {
                if(control is Panel panel)
                {
                 
                    if (panel.Location.X < LocationProductPreviewX || panel.Location.X > LocationProductNextX)
                    {
                        Controls.Remove(panel);
                        panel.Dispose();
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (thread == null || !thread.IsAlive)
            {
                previewProduct++;
                if (previewProduct > productList.Count - 1)
                {
                    previewProduct = 0;
                }

                nextProduct++;
                if (nextProduct > productList.Count - 1)
                {
                    nextProduct = 0;
                }



                var product = productList[nextProduct];
                CreateProductPanel(parentPanel, LocationProductNextX, $"panelProduct{nextProduct}", Color.Blue, product);
                RemovePanel();

                //lblPreview.Text = previewProduct.ToString();

                //lblNext.Text = nextProduct.ToString();

                //lblCountPanel.Text = countPanel().ToString();
                //MovePanels(-PanelMoveDistanceAfterSleep);

                thread = new Thread(() =>
                {
                    for (int j = 0; j < maxFor; j++)
                    {
                        Thread.Sleep(TimerSleep);
                        BeginInvoke(new Action(() =>
                        {
                            foreach (Control control in parentPanel.Controls)
                            {
                                if (control is Panel panel)
                                {
                                    panel.Left -= PanelMoveDistanceAfterSleep;
                                }
                            }
                        }));
                    }
                });
                thread.Start();
                RemovePanel();
                // lblCountPanel.Text = countPanel().ToString();
            }

        }
        public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            //    private const int zoomDistanceButtonX = 10;
            //private const int zoomDistanceButtonY = 10;
            btnNext.Location = new Point(btnNext.Location.X - zoomDistanceButtonX / 2, btnNext.Location.Y - zoomDistanceButtonY / 2);
            btnNext.Width += zoomDistanceButtonX;
            btnNext.Height += zoomDistanceButtonY;
            btnNext.BackColor = Color.OrangeRed;

        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.Location = new Point(btnNext.Location.X + zoomDistanceButtonX / 2, btnNext.Location.Y + zoomDistanceButtonY / 2);
            btnNext.Width -= zoomDistanceButtonX;
            btnNext.Height -= zoomDistanceButtonY;
            btnNext.BackColor = Color.Orange;
        }

        private void btnPreview_MouseEnter(object sender, EventArgs e)
        {
            btnPreview.Location = new Point(btnPreview.Location.X - zoomDistanceButtonX / 2, btnPreview.Location.Y - zoomDistanceButtonY / 2);
            btnPreview.Width += zoomDistanceButtonX;
            btnPreview.Height += zoomDistanceButtonY;
            btnPreview.BackColor = Color.OrangeRed;
        }

        private void btnPreview_MouseLeave(object sender, EventArgs e)
        {
            btnPreview.Location = new Point(btnPreview.Location.X + zoomDistanceButtonX / 2, btnPreview.Location.Y + zoomDistanceButtonY / 2);
            btnPreview.Width -= zoomDistanceButtonX;
            btnPreview.Height -= zoomDistanceButtonY;
            btnPreview.BackColor = Color.Orange;
        }
    }
}
