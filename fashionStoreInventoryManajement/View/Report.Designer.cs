namespace fashionStoreInventoryManajement.View
{
    partial class Report
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
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pctBird = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDesainPurchases = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblDetailReport = new System.Windows.Forms.Label();
            this.pnlButtom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchases = new Guna.UI2.WinForms.Guna2Button();
            this.btnSales = new Guna.UI2.WinForms.Guna2Button();
            this.prgPurchases = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblValuePurchases = new System.Windows.Forms.Label();
            this.prgSales = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblValueSales = new System.Windows.Forms.Label();
            this.sprBatas = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).BeginInit();
            this.pnlButtom.SuspendLayout();
            this.prgPurchases.SuspendLayout();
            this.prgSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pnlTop.Controls.Add(this.pctBird);
            this.pnlTop.Controls.Add(this.btnDesainPurchases);
            this.pnlTop.Controls.Add(this.lblDetailReport);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1044, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // pctBird
            // 
            this.pctBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pctBird.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pctBird.Image = global::fashionStoreInventoryManajement.Properties.Resources.icons8_bird_48;
            this.pctBird.ImageRotate = 0F;
            this.pctBird.Location = new System.Drawing.Point(314, 18);
            this.pctBird.Name = "pctBird";
            this.pctBird.Size = new System.Drawing.Size(55, 46);
            this.pctBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBird.TabIndex = 13;
            this.pctBird.TabStop = false;
            // 
            // btnDesainPurchases
            // 
            this.btnDesainPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnDesainPurchases.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesainPurchases.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesainPurchases.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesainPurchases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesainPurchases.FillColor = System.Drawing.Color.White;
            this.btnDesainPurchases.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesainPurchases.ForeColor = System.Drawing.Color.White;
            this.btnDesainPurchases.Image = global::fashionStoreInventoryManajement.Properties.Resources.icons8_purchase_48;
            this.btnDesainPurchases.ImageSize = new System.Drawing.Size(60, 60);
            this.btnDesainPurchases.Location = new System.Drawing.Point(62, 13);
            this.btnDesainPurchases.Name = "btnDesainPurchases";
            this.btnDesainPurchases.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDesainPurchases.Size = new System.Drawing.Size(73, 75);
            this.btnDesainPurchases.TabIndex = 12;
            // 
            // lblDetailReport
            // 
            this.lblDetailReport.AutoSize = true;
            this.lblDetailReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblDetailReport.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailReport.ForeColor = System.Drawing.Color.White;
            this.lblDetailReport.Location = new System.Drawing.Point(375, 34);
            this.lblDetailReport.Name = "lblDetailReport";
            this.lblDetailReport.Size = new System.Drawing.Size(368, 30);
            this.lblDetailReport.TabIndex = 11;
            this.lblDetailReport.Text = "Report Purcahses and Sales";
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtom.Controls.Add(this.btnBack);
            this.pnlButtom.Controls.Add(this.btnPurchases);
            this.pnlButtom.Controls.Add(this.btnSales);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 613);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(1044, 100);
            this.pnlButtom.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 15;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(68, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 58);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.BorderRadius = 15;
            this.btnPurchases.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchases.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchases.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchases.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnPurchases.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPurchases.Location = new System.Drawing.Point(507, 20);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(192, 58);
            this.btnPurchases.TabIndex = 2;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnSales
            // 
            this.btnSales.BorderRadius = 15;
            this.btnSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnSales.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(773, 20);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(192, 58);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales";
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // prgPurchases
            // 
            this.prgPurchases.Controls.Add(this.lblValuePurchases);
            this.prgPurchases.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.prgPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prgPurchases.ForeColor = System.Drawing.Color.White;
            this.prgPurchases.Location = new System.Drawing.Point(127, 198);
            this.prgPurchases.Minimum = 0;
            this.prgPurchases.Name = "prgPurchases";
            this.prgPurchases.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prgPurchases.Size = new System.Drawing.Size(287, 287);
            this.prgPurchases.TabIndex = 3;
            // 
            // lblValuePurchases
            // 
            this.lblValuePurchases.AutoSize = true;
            this.lblValuePurchases.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuePurchases.ForeColor = System.Drawing.Color.Black;
            this.lblValuePurchases.Location = new System.Drawing.Point(46, 122);
            this.lblValuePurchases.Name = "lblValuePurchases";
            this.lblValuePurchases.Size = new System.Drawing.Size(87, 30);
            this.lblValuePurchases.TabIndex = 0;
            this.lblValuePurchases.Text = "Value";
            // 
            // prgSales
            // 
            this.prgSales.Controls.Add(this.lblValueSales);
            this.prgSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.prgSales.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prgSales.ForeColor = System.Drawing.Color.White;
            this.prgSales.Location = new System.Drawing.Point(636, 198);
            this.prgSales.Minimum = 0;
            this.prgSales.Name = "prgSales";
            this.prgSales.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prgSales.Size = new System.Drawing.Size(287, 287);
            this.prgSales.TabIndex = 4;
            // 
            // lblValueSales
            // 
            this.lblValueSales.AutoSize = true;
            this.lblValueSales.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSales.ForeColor = System.Drawing.Color.Black;
            this.lblValueSales.Location = new System.Drawing.Point(46, 122);
            this.lblValueSales.Name = "lblValueSales";
            this.lblValueSales.Size = new System.Drawing.Size(87, 30);
            this.lblValueSales.TabIndex = 1;
            this.lblValueSales.Text = "Value";
            // 
            // sprBatas
            // 
            this.sprBatas.Location = new System.Drawing.Point(507, 178);
            this.sprBatas.Name = "sprBatas";
            this.sprBatas.Size = new System.Drawing.Size(10, 406);
            this.sprBatas.TabIndex = 5;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(185, 522);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(144, 25);
            this.lblSales.TabIndex = 6;
            this.lblSales.Text = "Sales Results";
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchases.Location = new System.Drawing.Point(682, 522);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(191, 25);
            this.lblPurchases.TabIndex = 7;
            this.lblPurchases.Text = "Purchases Results";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 713);
            this.Controls.Add(this.lblPurchases);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.sprBatas);
            this.Controls.Add(this.prgSales);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.prgPurchases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            this.prgPurchases.ResumeLayout(false);
            this.prgPurchases.PerformLayout();
            this.prgSales.ResumeLayout(false);
            this.prgSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2PictureBox pctBird;
        private Guna.UI2.WinForms.Guna2CircleButton btnDesainPurchases;
        private System.Windows.Forms.Label lblDetailReport;
        private Guna.UI2.WinForms.Guna2Panel pnlButtom;
        private Guna.UI2.WinForms.Guna2Button btnSales;
        private Guna.UI2.WinForms.Guna2Button btnPurchases;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prgPurchases;
        private System.Windows.Forms.Label lblValuePurchases;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prgSales;
        private System.Windows.Forms.Label lblValueSales;
        private Guna.UI2.WinForms.Guna2VSeparator sprBatas;
        private System.Windows.Forms.Label lblSales;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblPurchases;
    }
}