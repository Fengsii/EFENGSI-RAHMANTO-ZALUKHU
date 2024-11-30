using fashionStoreInventoryManajement.Controller;
using Guna.UI2.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.View
{
    public partial class Purchases : Form
    {
        private FashionStoreController fashionStoreController;
        public Purchases()
        {
            fashionStoreController = new FashionStoreController();
            InitializeComponent();
        }

        private void btnAddPurchases_Click(object sender, EventArgs e)
        {
            AddPurchases addPurchases = new AddPurchases();
            addPurchases.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            showTable();
        }

        bool showTable()
        {
            dgvPurchases.DataSource = fashionStoreController.showPurchases(new MySqlCommand("SELECT * FROM Pembelian"));
            dgvPurchases.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dgvPurchases.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }

        private void dgvPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string productNama = dgvPurchases.Rows[e.RowIndex].Cells[3].Value.ToString();
                string category = dgvPurchases.Rows[e.RowIndex].Cells[2].Value.ToString();
                string size = dgvPurchases.Rows[e.RowIndex].Cells[4].Value.ToString();
                string price = dgvPurchases.Rows[e.RowIndex].Cells[6].Value.ToString();
                string supplier = dgvPurchases.Rows[e.RowIndex].Cells[1].Value.ToString();
                string date = dgvPurchases.Rows[e.RowIndex].Cells[8].Value.ToString();

                byte[] imageData = (byte[])dgvPurchases.Rows[e.RowIndex].Cells[9].Value;
                MemoryStream ms = new MemoryStream(imageData);
                Image productImage = Image.FromStream(ms);

                DetailPurchases detailPurchases = new DetailPurchases()
                {
                    ProductNamee = productNama,       
                    CategoryNamee = category,         
                    Sizee = size,                     
                    Price = price,                  
                    Supplier = supplier,             
                    Date = date,                    
                    ProductImage = productImage      
                };

                detailPurchases.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPurchases.CurrentRow != null)
            {
                string idPurchases = dgvPurchases.CurrentRow.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?","Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        fashionStoreController.deletePurchases(idPurchases);

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPurchases.DataSource = fashionStoreController.SearchPurchases(txtSearch.Text);
        }

        private void tmSearhDate_ValueChanged(object sender, EventArgs e)
        {
            // Mendapatkan input dari TextBox pencarian dan DateTimePicker
            string searchTerm = txtSearch.Text;
            DateTime? selectedDate = tmSearhDate.Value;

            // Panggil metode SearchProduct dengan parameter tanggal
            dgvPurchases.DataSource = fashionStoreController.SearchPurchases(searchTerm, selectedDate);
        }
    }
}
