namespace fashionStoreInventoryManajement.View
{
    partial class DetailSupplierPurchases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pctBird = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDetailSupplierPurchases = new System.Windows.Forms.Label();
            this.dgvReportSupplier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlCount = new Guna.UI2.WinForms.Guna2Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSupplier)).BeginInit();
            this.pnlCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pnlTop.Controls.Add(this.pctBird);
            this.pnlTop.Controls.Add(this.lblDetailSupplierPurchases);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(875, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // pctBird
            // 
            this.pctBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pctBird.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pctBird.Image = global::fashionStoreInventoryManajement.Properties.Resources.icons8_bird_48;
            this.pctBird.ImageRotate = 0F;
            this.pctBird.Location = new System.Drawing.Point(208, 15);
            this.pctBird.Name = "pctBird";
            this.pctBird.Size = new System.Drawing.Size(56, 57);
            this.pctBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBird.TabIndex = 13;
            this.pctBird.TabStop = false;
            // 
            // lblDetailSupplierPurchases
            // 
            this.lblDetailSupplierPurchases.AutoSize = true;
            this.lblDetailSupplierPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblDetailSupplierPurchases.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailSupplierPurchases.ForeColor = System.Drawing.Color.White;
            this.lblDetailSupplierPurchases.Location = new System.Drawing.Point(266, 37);
            this.lblDetailSupplierPurchases.Name = "lblDetailSupplierPurchases";
            this.lblDetailSupplierPurchases.Size = new System.Drawing.Size(350, 30);
            this.lblDetailSupplierPurchases.TabIndex = 12;
            this.lblDetailSupplierPurchases.Text = "Detail Supplier Purcahses";
            // 
            // dgvReportSupplier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReportSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportSupplier.ColumnHeadersHeight = 28;
            this.dgvReportSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReportSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReportSupplier.Location = new System.Drawing.Point(12, 118);
            this.dgvReportSupplier.Name = "dgvReportSupplier";
            this.dgvReportSupplier.RowHeadersVisible = false;
            this.dgvReportSupplier.RowHeadersWidth = 62;
            this.dgvReportSupplier.RowTemplate.Height = 28;
            this.dgvReportSupplier.Size = new System.Drawing.Size(851, 477);
            this.dgvReportSupplier.TabIndex = 1;
            this.dgvReportSupplier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReportSupplier.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReportSupplier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReportSupplier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReportSupplier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReportSupplier.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReportSupplier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReportSupplier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReportSupplier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportSupplier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReportSupplier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReportSupplier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReportSupplier.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvReportSupplier.ThemeStyle.ReadOnly = false;
            this.dgvReportSupplier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReportSupplier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReportSupplier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReportSupplier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReportSupplier.ThemeStyle.RowsStyle.Height = 28;
            this.dgvReportSupplier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReportSupplier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReportSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportSupplier_CellClick);
            // 
            // pnlCount
            // 
            this.pnlCount.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCount.BorderRadius = 20;
            this.pnlCount.Controls.Add(this.lblValue);
            this.pnlCount.Controls.Add(this.lblGrandTotal);
            this.pnlCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pnlCount.Location = new System.Drawing.Point(372, 631);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Size = new System.Drawing.Size(458, 54);
            this.pnlCount.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(229, 15);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(65, 23);
            this.lblValue.TabIndex = 15;
            this.lblValue.Text = "Value";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblGrandTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.White;
            this.lblGrandTotal.Location = new System.Drawing.Point(21, 15);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(126, 23);
            this.lblGrandTotal.TabIndex = 14;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 15;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(88, 631);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 54);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DetailSupplierPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 713);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlCount);
            this.Controls.Add(this.dgvReportSupplier);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailSupplierPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailSupplierPurchases";
            this.Load += new System.EventHandler(this.DetailSupplierPurchases_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportSupplier)).EndInit();
            this.pnlCount.ResumeLayout(false);
            this.pnlCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblDetailSupplierPurchases;
        private Guna.UI2.WinForms.Guna2PictureBox pctBird;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReportSupplier;
        private Guna.UI2.WinForms.Guna2Panel pnlCount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblValue;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}