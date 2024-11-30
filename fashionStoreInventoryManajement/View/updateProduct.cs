using fashionStoreInventoryManajement.Controller;
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
    public partial class updateProduct : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public updateProduct()
        {
            fashionStoreController = new FashionStoreController();
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (pctProduct.Image == null)
                {
                    MessageBox.Show("Silakan unggah gambar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParse(txtDate.Text, out DateTime parsedDate))
                {
                    MessageBox.Show("Format tanggal tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pctProduct.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                fashionStoreController.updateProduct(
                    txtIdProduct.Text,
                    txtIdPurchases.Text,
                    txtCategory.Text,
                    txtNameClothes.Text,
                    txtSize.Text,
                    txtPricee.Text,
                    txtStockProduct.Text,
                    parsedDate,
                    imageBytes
                );

                MessageBox.Show("Data produk berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Product product = new Product();
                product.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Select Photo (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(opf.FileName, FileMode.Open, FileAccess.Read))
                        {
                            pctProduct.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void updateProduct_Load(object sender, EventArgs e)
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
