using fashionStoreInventoryManajement.Controller;
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
    public partial class UpdateCategory : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public UpdateCategory()
        {
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdCategory(txtIDUpdateCategory.Text))
            {
                MessageBox.Show("ID Category tidak valid. Harus diawali 'C0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDUpdateCategory.Focus();
                return;
            }

            if (!validasiController.ValidasiNameProduct(txtUpdateNameCategory.Text))
            {
                MessageBox.Show("Nama Category tidak valid. Panjang harus 3-11 karakter tanpa angka atau simbol.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdateNameCategory.Focus();
                return;
            }

            fashionStoreController = new FashionStoreController();
            fashionStoreController.updateCategory(txtIDUpdateCategory.Text, txtUpdateNameCategory.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDUpdateCategory.Focus();
            MessageBox.Show("Data Category Berhasil Disimpan");

            Category category = new Category();
            category.Show();
            category.showTable();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            txtIDUpdateCategory.MaxLength = 4;
            txtUpdateNameCategory.MaxLength = 11;
        }
    }
}
