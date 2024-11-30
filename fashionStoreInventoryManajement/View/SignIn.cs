using fashionStoreInventoryManajement.Controller;
using fashionStoreInventoryManajement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement
{
    public partial class SignIn : Form
    {
        private LoginController loginController;
        private ValidasiController validasiController;
        public SignIn()
        {
            loginController = new LoginController();
            validasiController = new ValidasiController();
            InitializeComponent();
        }

        private void lblExitlog_MouseEnter(object sender, EventArgs e)
        {
            lblExitlog.ForeColor = Color.Red;
        }

        private void lblExitlog_MouseLeave(object sender, EventArgs e)
        {
            lblExitlog.ForeColor = Color.FromArgb(112, 136, 113);
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.FillColor = Color.Red;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FillColor = Color.FromArgb(22, 50, 91);
        }

        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.FillColor = Color.Red;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.FillColor = Color.FromArgb(22, 50, 91);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if ((txtPassword.Text == "") || (txtUserrname.Text == ""))
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = txtUserrname.Text;
                string password = txtPassword.Text;

               
                DataTable table = loginController.getList(new MySqlConnector.MySqlCommand
                ("SELECT * FROM Admin WHERE username = '" + username + "' AND passwordd = '" + password + "'"));



                if (table.Rows.Count > 0)
                {
                    Beranda beranda = new Beranda();
                    beranda.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your admin and password are not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void lblExitlog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctOpenEyes_Click(object sender, EventArgs e)
        {
            // Jika mata terbuka diklik, tampilkan mata tertutup dan tampilkan password
            pctOpenEyes.Visible = false;
            pctCloseEyes.Visible = true;
            txtPassword.PasswordChar = '*'; // Menggunakan karakter khusus
        }

        private void pctCloseEyes_Click(object sender, EventArgs e)
        {
            // Jika mata tertutup diklik, tampilkan mata terbuka dan sembunyikan password
            pctOpenEyes.Visible = true;
            pctCloseEyes.Visible = false;
            txtPassword.PasswordChar = '\0'; // Menampilkan password
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // Setel awal dengan mata terbuka (password tersembunyi)
            pctOpenEyes.Visible = false;  // Mata terbuka
            pctCloseEyes.Visible = true; // Mata tertutup
            txtPassword.PasswordChar = '*'; // Menggunakan karakter khusus
            txtPassword.MaxLength = 11;
            txtUserrname.MaxLength = 11;
        }
    }
}
