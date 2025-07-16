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
    public partial class addSales : Form
    {
        private FashionStoreController fashionStoreController;
        private ValidasiController validasiController;
        public addSales()
        {
            fashionStoreController = new FashionStoreController();
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void addSales_Load(object sender, EventArgs e)
        {
            txtQtyPruduct.MaxLength = 7;
            txtIdSales.MaxLength = 4;
            txtIdCustomer.MaxLength = 4;
            txtIdProduct.MaxLength = 4;

        }

        bool verify()
        {
            if ((txtIdSales.Text == "") || (txtIdCustomer.Text == "") || (txtIdProduct.Text == "") || (txtQtyPruduct.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {

            if (!validasiController.ValidasiIdSales(txtIdSales.Text))
            {
                MessageBox.Show("ID Sales tidak valid. Harus diawali 'F0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdSales.Focus();
                return;
            }

            if (!validasiController.ValidasiIdCustomer(txtIdCustomer.Text))
            {
                MessageBox.Show("ID Customer tidak valid. Harus diawali 'B0' dan diikuti 2 angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCustomer.Focus();
                return;
            }

            if (!validasiController.ValidasiHanyaAngka(txtIdProduct.Text))
            {
                MessageBox.Show("ID Product hanya boleh berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdProduct.Focus();
                return;
            }

            if (!validasiController.ValidasiHanyaAngka(txtQtyPruduct.Text))
            {
                MessageBox.Show("Stok hanya boleh berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtyPruduct.Focus();
                return;
            }


            if (verify())
            {
                try
                {
                    fashionStoreController.addSales(txtIdSales.Text, txtIdCustomer.Text, txtIdProduct.Text, txtQtyPruduct.Text, txtDate.Value);

                    MessageBox.Show("Penambahan data baru berhasil", "Simpan data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdSales.Focus();


                    Sales sales = new Sales();
                    sales.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Inputan kosong", "Tambah data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
