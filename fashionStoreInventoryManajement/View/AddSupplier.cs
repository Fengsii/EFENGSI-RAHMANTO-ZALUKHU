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
    public partial class AddSupplier : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public AddSupplier()
        {
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Hide();
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdSupplier(txtIDSupp.Text))
            {
                MessageBox.Show("ID Supplier tidak valid. ID harus berupa 4 karakter dimulai dengan 'A0' diikuti angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDSupp.Focus();
                return;
            }

            if (!validasiController.ValidasiNama(txtNameSupp.Text))
            {
                MessageBox.Show("Nama Supplier tidak valid. Nama hanya boleh berisi huruf, maksimal 3 spasi, dan tidak boleh spasi berturut-turut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameSupp.Focus();
                return;
            }

            if (!validasiController.ValidasiNomorHP(txtNoHpsupp.Text))
            {
                MessageBox.Show("Nomor HP tidak valid. Format yang diperbolehkan: +628, 628, atau 08 diikuti digit angka yang sesuai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoHpsupp.Focus();
                return;
            }


            fashionStoreController = new FashionStoreController();
            fashionStoreController.addSupplier(txtIDSupp.Text, txtNameSupp.Text, txtNoHpsupp.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDSupp.Focus();
            MessageBox.Show("Data Supplier Berhasil Disimpan");

            Supplier supplier = new Supplier();
            supplier.Show();
            this.Hide();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            txtIDSupp.MaxLength = 4;
            txtNameSupp.MaxLength = 30;
            txtNoHpsupp.MaxLength = 14;
        }
    }
}
