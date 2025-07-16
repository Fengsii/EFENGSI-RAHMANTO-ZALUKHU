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
    public partial class DetailPurchases : Form
    {
        public string ProductNamee { get; set; }
        public string CategoryNamee { get; set; }
        public string Sizee { get; set; }
        public string Price { get; set; }
        public string Supplier { get; set; }
        public string Date { get; set; }
        public Image ProductImage { get; set; }

        public DetailPurchases()
        {
            InitializeComponent();
        }

        private void DetailPurchases_Load(object sender, EventArgs e)
        {
            // Tampilkan data di TextBox dan PictureBox
            txtProductName.Text = ProductNamee;
            txtCategory.Text = CategoryNamee;
            txtSize.Text = Sizee;
            txtPrice.Text = Price;
            txtSupplier.Text = Supplier;
            txtDate.Text = Date;
            pictProduct.Image = ProductImage;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            purchases.Show();
            this.Hide();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
