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
    public partial class AddCustomers : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public AddCustomers()
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdCustomer(txtIDCustomer.Text))
            {
                MessageBox.Show("ID Customer tidak valid. ID harus berupa 4 karakter dimulai dengan 'B0' diikuti angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDCustomer.Focus();
                return;
            }

            if (!validasiController.ValidasiNama(txtNameCustomer.Text))
            {
                MessageBox.Show("Nama Customer tidak valid. Nama hanya boleh berisi huruf, maksimal 3 spasi, dan tidak boleh spasi berturut-turut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameCustomer.Focus();
                return;
            }

            if (!validasiController.ValidasiNomorHP(txtNoHpCustomer.Text))
            {
                MessageBox.Show("Nomor HP tidak valid. Format yang diperbolehkan: +628, 628, atau 08 diikuti digit angka yang sesuai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoHpCustomer.Focus();
                return;
            }


            fashionStoreController = new FashionStoreController();
            fashionStoreController.addCustomer(txtIDCustomer.Text, txtNameCustomer.Text, txtNoHpCustomer.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDCustomer.Focus();
            MessageBox.Show("Data Customer Berhasil Disimpan");

            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {
            txtIDCustomer.MaxLength = 4;
            txtNameCustomer.MaxLength = 30;
            txtNoHpCustomer.MaxLength = 14;
        }
    }
}
