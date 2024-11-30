using fashionStoreInventoryManajement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fashionStoreInventoryManajement.View
{
    public partial class Report : Form
    {
        private FashionStoreController fashionStoreController;
        public Report()
        {
            fashionStoreController = new FashionStoreController();
            InitializeComponent();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            DetailSupplierPurchases detailSupplierPurchases = new DetailSupplierPurchases();
            detailSupplierPurchases.Show();
            this.Hide();
        }

     

        private void btnSales_Click(object sender, EventArgs e)
        {
            reportSales reportSales = new reportSales();
            reportSales.Show();
            this.Hide();
        }

      
        private void Report_Load(object sender, EventArgs e)
        {
            DataTable salesReportData = fashionStoreController.getSalesReport();
            DataTable purchaseReportData = fashionStoreController.getSupplierPurchasesReport();

            decimal totalSales = CalculateTotal(salesReportData);
            decimal totalPurchases = CalculateTotal(purchaseReportData);

            prgSales.Value = GetProgressValue(totalSales);
            lblValueSales.Text = totalSales.ToString("C", new CultureInfo("id-ID")); 

            prgPurchases.Value = GetProgressValue(totalPurchases);
            lblValuePurchases.Text = totalPurchases.ToString("C", new CultureInfo("id-ID")); 

        }

        private decimal CalculateTotal(DataTable reportData)
        {
            decimal total = 0;

            if (reportData.Columns.Contains("Total"))
            {
                foreach (DataRow row in reportData.Rows)
                {
                    total += Convert.ToDecimal(row["Total"]);
                }
            }
            else if (reportData.Columns.Contains("Total Harga"))
            {
                foreach (DataRow row in reportData.Rows)
                {
                    total += Convert.ToDecimal(row["Total Harga"]);
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Total' atau 'Total Harga' tidak ditemukan dalam data.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return total;
        }


        private int GetProgressValue(decimal total)
        {
            decimal maxValue = 10000000; 
            return (int)((total / maxValue) * 100); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Beranda beranda = new Beranda();
            beranda.Show();
            this.Hide();
        }
    }
}
