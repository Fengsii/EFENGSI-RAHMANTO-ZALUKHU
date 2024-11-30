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
    public partial class Product : Form
    {
        FashionStoreController fashionStoreController;
        public Product()
        {
            fashionStoreController = new FashionStoreController();
            InitializeComponent();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            showTable();
        }

        bool showTable()
        {
            dgvProductt.DataSource = fashionStoreController.showProduct(new MySqlCommand("SELECT * FROM Pembelian"));
            dgvProductt.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dgvProductt.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }

        private void dgvProductt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string productNama = dgvProductt.Rows[e.RowIndex].Cells[3].Value.ToString();
                string IdProduct = dgvProductt.Rows[e.RowIndex].Cells[0].Value.ToString();
                string size = dgvProductt.Rows[e.RowIndex].Cells[4].Value.ToString();
                string price = dgvProductt.Rows[e.RowIndex].Cells[5].Value.ToString();
                string stok = dgvProductt.Rows[e.RowIndex].Cells[6].Value.ToString();
                string date = dgvProductt.Rows[e.RowIndex].Cells[7].Value.ToString();

                byte[] imageData = (byte[])dgvProductt.Rows[e.RowIndex].Cells[8].Value;
                MemoryStream ms = new MemoryStream(imageData);
                Image productImage = Image.FromStream(ms);

                DetailProduct detailProduct = new DetailProduct()
                {
                    ProductNamee = productNama,
                    IdProduct = IdProduct,
                    Sizee = size,
                    Price = price,
                    Stok = stok,
                    Date = date,
                    ProductImage = productImage
                };

                detailProduct.Show();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductt.CurrentRow != null)
            {
                string idProduct = dgvProductt.CurrentRow.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        fashionStoreController.deleteProduct(idProduct);

                        showTable();

                        MessageBox.Show("Hapus data berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            updateProduct updateProduct = new updateProduct();
            updateProduct.Show();
            this.Hide();

            updateProduct.txtIdProduct.Text = this.dgvProductt.CurrentRow.Cells[0].Value.ToString();
            updateProduct.txtIdPurchases.Text = this.dgvProductt.CurrentRow.Cells[1].Value.ToString();
            updateProduct.txtCategory.Text = this.dgvProductt.CurrentRow.Cells[2].Value.ToString();
            updateProduct.txtNameClothes.Text = this.dgvProductt.CurrentRow.Cells[3].Value.ToString();
            updateProduct.txtSize.Text = this.dgvProductt.CurrentRow.Cells[4].Value.ToString();
            updateProduct.txtPricee.Text = this.dgvProductt.CurrentRow.Cells[5].Value.ToString();
            updateProduct.txtStockProduct.Text = this.dgvProductt.CurrentRow.Cells[6].Value.ToString();
            updateProduct.txtDate.Text = this.dgvProductt.CurrentRow.Cells[7].Value.ToString();

            byte[] imageData = (byte[])dgvProductt.CurrentRow.Cells[8].Value; 
            using (MemoryStream ms = new MemoryStream(imageData)) 
            {
                updateProduct.pctProduct.Image = Image.FromStream(ms); 
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProductt.DataSource = fashionStoreController.SearchProduct(txtSearch.Text);
        }

        private void tmSearhDate_ValueChanged(object sender, EventArgs e)
        {
            // Mendapatkan input dari TextBox pencarian dan DateTimePicker
            string searchTerm = txtSearch.Text;
            DateTime? selectedDate = tmSearhDate.Value;

            // Panggil metode SearchProduct dengan parameter tanggal
            dgvProductt.DataSource = fashionStoreController.SearchProduct(searchTerm, selectedDate);
        }
    }
}
