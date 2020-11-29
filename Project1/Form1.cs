using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productText = "Ürünler";
            string addToCartButtonText = "Sepete ekle";
            string deleteFromCartButtonText = "Ürün Sil";
            var cartText = "Sepetiniz";

            lblProducts.Text = productText;
            btnAddToCart.Text = addToCartButtonText;
            btnDeleteFromCart.Text = deleteFromCartButtonText;
            lblCart.Text = cartText;

            string[] products = new string[] { "Laptop", "Masaüstü Pc", "Klavye" };
            foreach (var product in products)
            {
                lbxProducts.Items.Add(product);
            }
            btnDeleteFromCart.Enabled = false;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tıklandı");
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnDeleteFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Öncelikle bir ürün seçmelisiniz.");
            }
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle sepetten bir ürün seçmelisiniz.");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnDeleteFromCart.Enabled = false;
            }

        }
    }
}
