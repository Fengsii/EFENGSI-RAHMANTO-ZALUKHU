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
    public partial class Customers : Form
    {
        private FashionStoreController fashionStoreController;
        public Customers()
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


        private void Customers_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dgvCustomerss.DataSource = fashionStoreController.showCustomer(new MySqlCommand("SELECT * FROM Customer"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvCustomerss.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            AddCustomers addCustomers = new AddCustomers();
            addCustomers.ShowDialog();
            this.Hide();
        }

        private void btnUpdateCustom_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog();
            this.Hide();

            updateCustomer.txtIDCustomerUpdate.Text = this.dgvCustomerss.CurrentRow.Cells[0].Value.ToString();
            updateCustomer.txtNameCustomerUpdate.Text = this.dgvCustomerss.CurrentRow.Cells[1].Value.ToString();
            updateCustomer.txtNoHpCustomerUpdate.Text = this.dgvCustomerss.CurrentRow.Cells[2].Value.ToString();
        }

        bool verify()
        {
            if ((txtIdCustom.Text == "") || (txtUserNameCustom.Text == "") || (txtNumberPhonCustom.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDeleteCustom_Click(object sender, EventArgs e)
        {
            if (verify())

            {
                try
                {
                    fashionStoreController.deleteCustomer(txtIdCustom.Text);
                    showTable();
                    btnClearCustom.PerformClick();
                    MessageBox.Show("Customer delete succesfully", "Delete Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_Customer not delete", "Delete Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearCustom_Click(object sender, EventArgs e)
        {
            txtIdCustom.Clear();
            txtUserNameCustom.Clear();
            txtNumberPhonCustom.Clear();
        }

        private void dgvCustomerss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCustom.Text = dgvCustomerss.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserNameCustom.Text = dgvCustomerss.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNumberPhonCustom.Text = dgvCustomerss.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

       


        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.FillColor = Color.Tomato;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnAddCustom_MouseEnter(object sender, EventArgs e)
        {
            btnAddCustom.FillColor = Color.Tomato;
        }

        private void btnAddCustom_MouseLeave(object sender, EventArgs e)
        {
            btnAddCustom.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnUpdateCustom_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateCustom.FillColor = Color.Tomato;
        }

        private void btnUpdateCustom_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateCustom.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnDeleteCustom_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteCustom.FillColor = Color.Tomato;
        }

        private void btnDeleteCustom_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteCustom.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnClearCustom_MouseEnter(object sender, EventArgs e)
        {
            btnClearCustom.FillColor = Color.Tomato;
        }

        private void btnClearCustom_MouseLeave(object sender, EventArgs e)
        {
            btnClearCustom.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerss.DataSource = fashionStoreController.SearchCustomer(txtSearch.Text);
        }
    }
}
