using fashionStoreInventoryManajement.Controller;
using Guna.UI2.WinForms;
using MySqlConnector;
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
    public partial class AddPurchases : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public AddPurchases()
        {
            validasiController = new ValidasiController();
            fashionStoreController = new FashionStoreController();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            purchases.Show();
            this.Hide();
        }

        private void AddPurchases_Load(object sender, EventArgs e)
        {
            txtIdPurchases.MaxLength = 4;
            txtCategory.MaxLength = 4;
            txtIdSupplier.MaxLength = 4;
            txtMount.MaxLength = 4;
            txtPrice.MaxLength = 7;
            txtSize.MaxLength = 2;
            txtNameClothes.MaxLength = 14;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pctPurchases.Image = Image.FromFile(opf.FileName);
        }

        bool verify()
        {
            if ((txtIdPurchases.Text == "") || (txtIdSupplier.Text == "") || (txtCategory.Text == "") || (txtNameClothes.Text == "") || (txtSize.Text == "") ||
                (txtMount.Text == "") || (txtPrice.Text == "") || (pctPurchases.Image == null))
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

            if (!validasiController.ValidasiIdSupplier(txtIdSupplier.Text))
            {
                MessageBox.Show("ID Supplier tidak valid. Harus diawali 'A0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!validasiController.ValidasiHanyaAngka(txtPrice.Text))
            {
                MessageBox.Show("Harga hanya boleh berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!validasiController.ValidasiHanyaAngka(txtMount.Text))
            {
                MessageBox.Show("Jumlah hanya boleh berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMount.Focus();
                return;
            }



            if (verify())
            {
               
                try
                {
                    MemoryStream memori = new MemoryStream();
                    pctPurchases.Image.Save(memori, pctPurchases.Image.RawFormat);
                    byte[] img = memori.ToArray();

                    int totalPrice = Convert.ToInt32(txtMount.Text) * Convert.ToInt32(txtPrice.Text);

                    fashionStoreController.addPurchasest(txtIdPurchases.Text, txtIdSupplier.Text, txtCategory.Text, txtNameClothes.Text,
                        txtSize.Text, txtMount.Text, txtPrice.Text, txtDate.Value, img);

                    MessageBox.Show("Penambahan data baru berhasil", "Simpan data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPurchases.Focus();

                    Purchases purchases = new Purchases();
                    purchases.Show();
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
}
