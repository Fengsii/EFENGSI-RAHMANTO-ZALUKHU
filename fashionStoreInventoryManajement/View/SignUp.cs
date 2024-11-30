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
    public partial class SignUp : Form
    {
        private LoginController loginController;
        private ValidasiController validasiController;
        public SignUp()
        {
            validasiController = new ValidasiController();
            loginController = new LoginController();
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

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.FillColor = Color.Red;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.FillColor = Color.FromArgb(22, 50, 91);
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.FillColor = Color.Red;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.FillColor = Color.FromArgb(22, 50, 91);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignIn form = new SignIn();
            form.Show();
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

        private void SignUp_Load(object sender, EventArgs e)
        {
            // Setel awal dengan mata terbuka (password tersembunyi)
            pctOpenEyes.Visible = false;  // Mata terbuka
            pctCloseEyes.Visible = true; // Mata tertutup
            txtPassword.PasswordChar = '*'; // Menggunakan karakter khusus

            txtPassword.MaxLength = 11;
            txtUsernameUp.MaxLength = 11;
        }

        private bool VerifyInput()
        {
            if (string.IsNullOrEmpty(txtUsernameUp.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!validasiController.ValidasiUsername(txtUsernameUp.Text))
            {
                MessageBox.Show("Username tidak valid. Panjang 3-11 karakter, tanpa spasi ganda, dan karakter khusus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!validasiController.ValidasiPassword(txtPassword.Text))
            {
                MessageBox.Show("Password tidak valid. Panjang 3-11 karakter, minimal 2 angka dan 1 huruf.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (VerifyInput())
            {
                loginController.addAdmin(txtUsernameUp.Text, txtPassword.Text);
                MessageBox.Show("Data berhasil disimpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }
    }
}


