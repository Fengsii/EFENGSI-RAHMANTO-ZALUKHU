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
    public partial class AddCategory : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public AddCategory()
        {
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdCategory(txtIDCategory.Text))
            {
                MessageBox.Show("ID Category tidak valid. Harus diawali 'C0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDCategory.Focus();
                return;
            }

            if (!validasiController.ValidasiNameProduct(txtNameCategory.Text))
            {
                MessageBox.Show("Nama Category tidak valid. Panjang harus 3-11 karakter tanpa angka atau simbol.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameCategory.Focus();
                return;
            }

            fashionStoreController = new FashionStoreController();
            fashionStoreController.addCategory(txtIDCategory.Text, txtNameCategory.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDCategory.Focus();
            MessageBox.Show("Data Category Berhasil Disimpan");

            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            txtIDCategory.MaxLength = 4;
            txtNameCategory.MaxLength = 11;
        }
    }
}
