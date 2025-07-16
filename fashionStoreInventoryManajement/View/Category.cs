using fashionStoreInventoryManajement.Controller;
using MySqlConnector;
using System;

//using System;
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
    public partial class Category : Form
    {
        private FashionStoreController fashionStoreController;
        public Category()
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

        private void btnAddCategory_MouseEnter(object sender, EventArgs e)
        {
            btnAddCategory.FillColor = Color.Tomato;
        }

        private void btnAddCategory_MouseLeave(object sender, EventArgs e)
        {
            btnAddCategory.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnUpdateCategory_MouseEnter(object sender, EventArgs e)
        {
            btnUpdateCategory.FillColor = Color.Tomato;
        }

        private void btnUpdateCategory_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateCategory.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnDeleteCategory_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteCategory.FillColor = Color.Tomato;
        }

        private void btnDeleteCategory_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteCategory.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnClearCategory_MouseEnter(object sender, EventArgs e)
        {
            btnClearCategory.FillColor = Color.Tomato;
        }

        private void btnClearCategory_MouseLeave(object sender, EventArgs e)
        {
            btnClearCategory.FillColor = Color.FromArgb(67, 53, 167);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
            this.Hide();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dgvCategoryy.DataSource = fashionStoreController.showCategory(new MySqlCommand("SELECT * FROM Category"));
            //dgvKoleksi.RowTemplate.Height = 50;
            //agar kolom menyesuaikan secara otomatis dengan lebar DataGridView
            dgvCategoryy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory updateCategory = new UpdateCategory();
            updateCategory.Show();
            this.Hide();

            updateCategory.txtIDUpdateCategory.Text = this.dgvCategoryy.CurrentRow.Cells[0].Value.ToString();
            updateCategory.txtUpdateNameCategory.Text = this.dgvCategoryy.CurrentRow.Cells[1].Value.ToString();
        }

        bool verify()
        {
            if ((txtIdCategory.Text == "") || (txtUserNameCategory.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (verify())

            {
                try
                {
                    fashionStoreController.deleteCategory(txtIdCategory.Text);
                    showTable();
                    btnClearCategory.PerformClick();
                    MessageBox.Show("Category delete succesfully", "Delete Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error_Category not delete", "Delete Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            txtIdCategory.Clear();
            txtUserNameCategory.Clear();
        }

      

        private void dgvCategoryy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCategory.Text = dgvCategoryy.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserNameCategory.Text = dgvCategoryy.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCategoryy.DataSource = fashionStoreController.SearchCategory(txtSearch.Text);
        }

      
    }
}
