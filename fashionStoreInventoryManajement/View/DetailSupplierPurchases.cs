﻿using fashionStoreInventoryManajement.Controller;
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
    public partial class DetailSupplierPurchases : Form
    {
        private FashionStoreController fashionStoreController;
        public DetailSupplierPurchases()
        {
            InitializeComponent();
            fashionStoreController = new FashionStoreController();
        }

        private void DetailSupplierPurchases_Load(object sender, EventArgs e)
        {
            
            DataTable reportData = fashionStoreController.getSupplierPurchasesReport();

            dgvReportSupplier.DataSource = reportData;

            decimal totalSales = CalculateTotal(reportData);

            lblValue.Text = totalSales.ToString("C", new System.Globalization.CultureInfo("id-ID"));

        }

        private decimal CalculateTotal(DataTable reportData)
        {
            decimal total = 0;

            foreach (DataRow row in reportData.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }

            return total;
        }

        private void dgvReportSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }
    }
}