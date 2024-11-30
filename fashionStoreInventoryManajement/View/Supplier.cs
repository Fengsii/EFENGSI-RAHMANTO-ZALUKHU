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
    public partial class Supplier : Form
    {
        FashionStoreController fashionStoreController;
        public Supplier()
        {
            fashionStoreController = new FashionStoreController();
            InitializeComponent();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.FillColor = Color.Tomato;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void btnAddSupp_MouseEnter(object sender, EventArgs e)
        {
            btnAddSupp.FillColor = Color.Tomato;
        }

        private void btnAddSupp_MouseLeave(object sender, EventArgs e)
        {
            btnAddSupp.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnUpdateSupp_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateSupp.FillColor = Color.Tomato;
        }

        private void btnUpdateSupp_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateSupp.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnDeleteSupp_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteSupp.FillColor = Color.Tomato;
        }

        private void btnDeleteSupp_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteSupp.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnClearSupp_MouseEnter(object sender, EventArgs e)
        {
            btnClearSupp.FillColor = Color.Tomato;
        }

        private void btnClearSupp_MouseLeave(object sender, EventArgs e)
        {
            btnClearSupp.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
            this.Hide();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dgvSupplier.DataSource = fashionStoreController.showSupplier(new MySqlCommand("SELECT * FROM Supplier"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdateSupp_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.ShowDialog();
            this.Hide();

            updateSupplier.txtIDSuppUpdate.Text = this.dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            updateSupplier.txtNameSuppUpdate.Text = this.dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            updateSupplier.txtNoHpsuppUpdate.Text = this.dgvSupplier.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdSupp.Text = dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserNameSupp.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNumberPhonSupp.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

       

        bool verify()
        {
            if ((txtIdSupp.Text == "") || (txtUserNameSupp.Text == "") || (txtNumberPhonSupp.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            if (verify())

            {
                try
                {
                    fashionStoreController.deleteSupplier(txtIdSupp.Text);
                    showTable();
                    btnClearSupp.PerformClick();
                    MessageBox.Show("Supplier delete succesfully", "Delete Supplier",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_Supplier not delete", "Delete Supplier",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearSupp_Click(object sender, EventArgs e)
        {
            txtIdSupp.Clear();
            txtUserNameSupp.Clear();
            txtNumberPhonSupp.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = fashionStoreController.SearchSupplier(txtSearch.Text);
        }
    }
}
