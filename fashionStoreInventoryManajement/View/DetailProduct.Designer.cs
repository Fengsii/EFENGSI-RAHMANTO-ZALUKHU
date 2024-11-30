namespace fashionStoreInventoryManajement.View
{
    partial class DetailProduct
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
            this.lblClose = new System.Windows.Forms.Label();
            this.pctBird = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDetailProduct = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txtDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtStockProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.txtIDProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pnlTop.Controls.Add(this.lblClose);
            this.pnlTop.Controls.Add(this.pctBird);
            this.pnlTop.Controls.Add(this.lblDetailProduct);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(710, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblClose.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(644, 22);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 26);
            this.lblClose.TabIndex = 16;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pctBird
            // 
            this.pctBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pctBird.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pctBird.Image = global::fashionStoreInventoryManajement.Properties.Resources.icons8_bird_48;
            this.pctBird.ImageRotate = 0F;
            this.pctBird.Location = new System.Drawing.Point(214, 22);
            this.pctBird.Name = "pctBird";
            this.pctBird.Size = new System.Drawing.Size(56, 57);
            this.pctBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBird.TabIndex = 15;
            this.pctBird.TabStop = false;
            // 
            // lblDetailProduct
            // 
            this.lblDetailProduct.AutoSize = true;
            this.lblDetailProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblDetailProduct.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailProduct.ForeColor = System.Drawing.Color.White;
            this.lblDetailProduct.Location = new System.Drawing.Point(272, 39);
            this.lblDetailProduct.Name = "lblDetailProduct";
            this.lblDetailProduct.Size = new System.Drawing.Size(181, 26);
            this.lblDetailProduct.TabIndex = 14;
            this.lblDetailProduct.Text = "Detail Product";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(119, 510);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(119, 21);
            this.lblPurchaseDate.TabIndex = 27;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // txtDate
            // 
            this.txtDate.AutoRoundedCorners = true;
            this.txtDate.BorderRadius = 19;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.DefaultText = "";
            this.txtDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDate.Location = new System.Drawing.Point(31, 544);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.PlaceholderText = "";
            this.txtDate.ReadOnly = true;
            this.txtDate.SelectedText = "";
            this.txtDate.Size = new System.Drawing.Size(286, 41);
            this.txtDate.TabIndex = 26;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(112, 417);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(116, 21);
            this.lblSupplier.TabIndex = 25;
            this.lblSupplier.Text = "Stock Product";
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.AutoRoundedCorners = true;
            this.txtStockProduct.BorderRadius = 19;
            this.txtStockProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockProduct.DefaultText = "";
            this.txtStockProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockProduct.Location = new System.Drawing.Point(31, 451);
            this.txtStockProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.PasswordChar = '\0';
            this.txtStockProduct.PlaceholderText = "";
            this.txtStockProduct.ReadOnly = true;
            this.txtStockProduct.SelectedText = "";
            this.txtStockProduct.Size = new System.Drawing.Size(286, 41);
            this.txtStockProduct.TabIndex = 24;
            this.txtStockProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(119, 328);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 21);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price Product";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.BorderRadius = 19;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(31, 362);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(286, 41);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(119, 234);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(105, 21);
            this.lblSize.TabIndex = 21;
            this.lblSize.Text = "Size Product";
            // 
            // txtSize
            // 
            this.txtSize.AutoRoundedCorners = true;
            this.txtSize.BorderRadius = 19;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.DefaultText = "";
            this.txtSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Location = new System.Drawing.Point(31, 268);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PlaceholderText = "";
            this.txtSize.ReadOnly = true;
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(286, 41);
            this.txtSize.TabIndex = 20;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.AutoSize = true;
            this.lblIDProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProduct.Location = new System.Drawing.Point(122, 143);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(91, 21);
            this.lblIDProduct.TabIndex = 19;
            this.lblIDProduct.Text = "ID Product";
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.AutoRoundedCorners = true;
            this.txtIDProduct.BorderRadius = 19;
            this.txtIDProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProduct.DefaultText = "";
            this.txtIDProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProduct.Location = new System.Drawing.Point(31, 177);
            this.txtIDProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.PasswordChar = '\0';
            this.txtIDProduct.PlaceholderText = "";
            this.txtIDProduct.ReadOnly = true;
            this.txtIDProduct.SelectedText = "";
            this.txtIDProduct.Size = new System.Drawing.Size(286, 41);
            this.txtIDProduct.TabIndex = 18;
            this.txtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(353, 143);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 442);
            this.guna2VSeparator1.TabIndex = 17;
            // 
            // txtProductName
            // 
            this.txtProductName.AutoRoundedCorners = true;
            this.txtProductName.BorderRadius = 19;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(405, 480);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(286, 41);
            this.txtProductName.TabIndex = 16;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictProduct
            // 
            this.pictProduct.BackColor = System.Drawing.Color.White;
            this.pictProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictProduct.ImageRotate = 0F;
            this.pictProduct.Location = new System.Drawing.Point(414, 143);
            this.pictProduct.Name = "pictProduct";
            this.pictProduct.Size = new System.Drawing.Size(267, 318);
            this.pictProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictProduct.TabIndex = 15;
            this.pictProduct.TabStop = false;
            // 
            // DetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 635);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtStockProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblIDProduct);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.pictProduct);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailProduct";
            this.Load += new System.EventHandler(this.DetailProduct_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblClose;
        private Guna.UI2.WinForms.Guna2PictureBox pctBird;
        private System.Windows.Forms.Label lblDetailProduct;
        private System.Windows.Forms.Label lblPurchaseDate;
        private Guna.UI2.WinForms.Guna2TextBox txtDate;
        private System.Windows.Forms.Label lblSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtStockProduct;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label lblSize;
        private Guna.UI2.WinForms.Guna2TextBox txtSize;
        private System.Windows.Forms.Label lblIDProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProduct;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2PictureBox pictProduct;
    }
}