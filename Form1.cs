using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private shoppingCart shoppingCart;
        public Form1()
        {
            InitializeComponent();
            shoppingCart = new shoppingCart();
            LoadProducts();
        }

        private void LoadProducts()
        {
            Product product1 = new Product("San pham 1", 10.00M, null, 5);
            Product product2 = new Product("San pham 2", 9.00M, null, 10);
            Product product3 = new Product("San pham 3", 8.00M, null, 6);
            Product product4 = new Product("San pham 4", 15.00M, null, 9);
            productListBox.Items.Add(product1);
            productListBox.Items.Add(product2);
            productListBox.Items.Add(product3);
            productListBox.Items.Add(product4);
        }

        private void btnaddToCart_Click(object sender, EventArgs e)
        {
            Product selectedProduct = productListBox.SelectedItem as Product;
            if (selectedProduct != null)
            {
                shoppingCart.AddProduct(selectedProduct);
                updateCart();
            }
        }

        private void btnremoveFromCart_Click(object sender, EventArgs e)
        {
            Product selectedProduct = productListBox.SelectedItem as Product;
            if (selectedProduct != null)
            {
                shoppingCart.RemoveProduct(selectedProduct);
                updateCart();
            }
        }

        private void updateCart()
        {
            cartListBox.Items.Clear();
            foreach (Product product in shoppingCart.GetProduct())
            {
                cartListBox.Items.Add(product);
            }
            totalvaluelbl.Text = $"Tổng thanh toán:{shoppingCart.TotalValue()}";

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn hàng đã được hoàn tất!","Thông báo");
            shoppingCart.Clear();
            updateCart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
