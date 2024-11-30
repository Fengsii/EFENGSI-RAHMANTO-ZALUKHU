using fashionStoreInventoryManajement.Controller;
using MySqlConnector;
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
    public partial class Sales : Form
    {
        private FashionStoreController fashionStoreController;
        public Sales()
        {
            fashionStoreController = new FashionStoreController();
            InitializeComponent();
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            addSales addSales = new addSales();
            addSales.Show();
            this.Hide();
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            if (dgvSales.CurrentRow != null)
            {
                string idProduct = dgvSales.CurrentRow.Cells[0].Value.ToString();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void showTable()
        {
            dgvSales.DataSource = fashionStoreController.showSales(new MySqlCommand("SELECT * FROM Penjualan"));
            dgvSales.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dgvSales.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dgvSales.DataSource = fashionStoreController.SearchSales(txtSearch.Text);

        }

        private void tmSearhDate_ValueChanged(object sender, EventArgs e)
        {
            // Mendapatkan input dari TextBox pencarian dan DateTimePicker
            string searchTerm = txtSearch.Text;
            DateTime? selectedDate = tmSearhDate.Value;

            // Panggil metode SearchProduct dengan parameter tanggal
            dgvSales.DataSource = fashionStoreController.SearchSales(searchTerm, selectedDate);
        }
    }
}
