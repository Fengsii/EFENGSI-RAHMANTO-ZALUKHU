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
    public partial class UpdateCustomer : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public UpdateCustomer()
        {
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdCustomer(txtIDCustomerUpdate.Text))
            {
                MessageBox.Show("ID Customer tidak valid. ID harus berupa 4 karakter dimulai dengan 'B0' diikuti angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDCustomerUpdate.Focus();
                return;
            }

            if (!validasiController.ValidasiNama(txtNameCustomerUpdate.Text))
            {
                MessageBox.Show("Nama Customer tidak valid. Nama hanya boleh berisi huruf, maksimal 3 spasi, dan tidak boleh spasi berturut-turut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameCustomerUpdate.Focus();
                return;
            }

            if (!validasiController.ValidasiNomorHP(txtNoHpCustomerUpdate.Text))
            {
                MessageBox.Show("Nomor HP tidak valid. Format yang diperbolehkan: +628, 628, atau 08 diikuti digit angka yang sesuai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoHpCustomerUpdate.Focus();
                return;
            }

            fashionStoreController = new FashionStoreController();
            fashionStoreController.updateCustomer(txtIDCustomerUpdate.Text, txtNameCustomerUpdate.Text, txtNoHpCustomerUpdate.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDCustomerUpdate.Focus();
            MessageBox.Show("Data Customer Berhasil Disimpan");

            Customers customers = new Customers();
            customers.Show();
            customers.showTable();
            this.Hide();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            txtIDCustomerUpdate.MaxLength = 4;
            txtNameCustomerUpdate.MaxLength = 30;
            txtNoHpCustomerUpdate.MaxLength = 14;
        }
    }
}
