using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class Product

    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Image image { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, Image image, int quantity)
        {
            Name = name;
            Price = price;
            this.image = image;
            Quantity = quantity;
        }
    }
    public class shoppingCart
    {
        private List<Product> products;

        public shoppingCart() 
        { 
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public decimal TotalValue()
        {
            return products.Sum(p=>p.Price);
        }

        public List<Product> GetProduct()
        { 
            return products; 
        }

        public void Clear()
        {
            products.Clear();
        }
    }
}
