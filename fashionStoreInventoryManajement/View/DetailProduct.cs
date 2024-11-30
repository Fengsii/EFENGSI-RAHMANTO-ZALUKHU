using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.View
{
    public partial class DetailProduct : Form
    {
        public string ProductNamee { get; set; }
        public string IdProduct { get; set; }
        public string Sizee { get; set; }
        public string Price { get; set; }
        public string Stok { get; set; }
        public string Date { get; set; }
        public Image ProductImage { get; set; }
        public DetailProduct()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Text = ProductNamee;
            txtIDProduct.Text = IdProduct;
            txtSize.Text = Sizee;
            txtPrice.Text = Price;
            txtStockProduct.Text = Stok;
            txtDate.Text = Date;
            pictProduct.Image = ProductImage;
        }
    }
}
