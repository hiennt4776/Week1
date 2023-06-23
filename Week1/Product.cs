using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkOfImage { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string linkOfImage, string description, double price)
        {
            Id = id;
            Name = name;
            LinkOfImage = linkOfImage;
            Description = description;
            Price = price;
        }
    }

}
