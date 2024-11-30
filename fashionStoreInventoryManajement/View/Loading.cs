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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            tmrLoading.Start();
            lblPersenn.Text = "0%"; // Set properti awal teks label
        }

        int startPoint = 0;

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            prbLoading.Value = startPoint;
            // Perbarui teks Label untuk menampilkan persentase
            lblPersenn.Text = startPoint + "%";
            if (prbLoading.Value == 100)
            {
                prbLoading.Value = 0;
                tmrLoading.Stop();
                SignIn form1 = new SignIn();
                form1.Show();
                this.Hide();
            }
        }
    }
}
