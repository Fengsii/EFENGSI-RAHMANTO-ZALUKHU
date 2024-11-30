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
    public partial class UpdateSupplier : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public UpdateSupplier()
        {
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnUpdateSupp_Click(object sender, EventArgs e)
        {
            if (!validasiController.ValidasiIdSupplier(txtIDSuppUpdate.Text))
            {
                MessageBox.Show("ID Supplier tidak valid. ID harus berupa 4 karakter dimulai dengan 'A0' diikuti angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDSuppUpdate.Focus();
                return;
            }

            if (!validasiController.ValidasiNama(txtNameSuppUpdate.Text))
            {
                MessageBox.Show("Nama Supplier tidak valid. Nama hanya boleh berisi huruf, maksimal 3 spasi, dan tidak boleh spasi berturut-turut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameSuppUpdate.Focus();
                return;
            }

            if (!validasiController.ValidasiNomorHP(txtNoHpsuppUpdate.Text))
            {
                MessageBox.Show("Nomor HP tidak valid. Format yang diperbolehkan: +628, 628, atau 08 diikuti digit angka yang sesuai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoHpsuppUpdate.Focus();
                return;
            }

            fashionStoreController = new FashionStoreController();
            fashionStoreController.updateSupplier(txtIDSuppUpdate.Text, txtNameSuppUpdate.Text, txtNoHpsuppUpdate.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtIDSuppUpdate.Focus();
            MessageBox.Show("Data Supplier Berhasil Disimpan");

            Supplier supplier = new Supplier();
            supplier.Show();
            supplier.showTable();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Hide();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            txtIDSuppUpdate.MaxLength = 4;
            txtNameSuppUpdate.MaxLength = 30;
            txtNoHpsuppUpdate.MaxLength = 14;
        }
    }
}
