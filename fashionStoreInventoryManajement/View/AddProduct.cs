using fashionStoreInventoryManajement.Controller;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.View
{
    public partial class AddProduct : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public AddProduct()
        {
            fashionStoreController = new FashionStoreController();
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pctProduct.Image = Image.FromFile(opf.FileName);
        }

        bool verify()
        {
            if ((txtIdPurchases.Text == "") || (txtCategory.Text == "") || (txtNameClothes.Text == "") || (txtSize.Text == "") ||
                (txtPricee.Text == "") || (txtStockProduct.Text == "") || (pctProduct.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdPurchases(txtIdPurchases.Text))
            {
                MessageBox.Show("ID Purchases tidak valid. Harus diawali 'E0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdPurchases.Focus();
                return;
            }

            if (!validasiController.ValidasiIdCategory(txtCategory.Text))
            {
                MessageBox.Show("ID Category tidak valid. Harus diawali 'C0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return;
            }

            if (!validasiController.ValidasiNameProduct(txtNameClothes.Text))
            {
                MessageBox.Show("Nama Produk tidak valid. Panjang harus 3-11 karakter tanpa angka atau simbol.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameClothes.Focus();
                return;
            }

            if (!validasiController.ValidasiSize(txtSize.Text))
            {
                MessageBox.Show("Ukuran tidak valid. Hanya diperbolehkan M, L, XL, atau sejenisnya.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSize.Focus();
                return;
            }

            if (!validasiController.ValidasiHanyaAngka(txtPricee.Text))
            {
                MessageBox.Show("Harga hanya boleh berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricee.Focus();
                return;
            }

            if (!validasiController.ValidasiHanyaAngka(txtStockProduct.Text))
            {
                MessageBox.Show("Stok hanya boleh berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStockProduct.Focus();
                return;
            }

            // Verifikasi Semua Inputan Tidak Kosong
            if (verify())
            {
                try
                {
                    MemoryStream memori = new MemoryStream();
                    pctProduct.Image.Save(memori, pctProduct.Image.RawFormat);
                    byte[] img = memori.ToArray();
                    fashionStoreController.addProduct(txtIdPurchases.Text, txtCategory.Text, txtNameClothes.Text, txtSize.Text, txtPricee.Text, txtStockProduct.Text,
                    txtDate.Value, img);

                    MessageBox.Show("Penambahan data baru berhasil", "Simpan data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPurchases.Focus();

                    Product product = new Product();
                    product.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inputan kosong", "Tambah data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AddProduct_Load(object sender, EventArgs e)
        {
            txtIdPurchases.MaxLength = 4;
            txtCategory.MaxLength = 4;
            txtNameClothes.MaxLength = 14;
            txtSize.MaxLength = 2;
            txtPricee.MaxLength = 7;
            txtStockProduct.MaxLength = 4;
        }
    }
}
