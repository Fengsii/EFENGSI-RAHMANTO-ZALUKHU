namespace fashionStoreInventoryManajement.View
{
    partial class Supplier
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
            this.pnlTopSup = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSupplierList = new System.Windows.Forms.Label();
            this.sprGaris = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvSupplier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlDownSupp = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClearSupp = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteSupp = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateSupp = new Guna.UI2.WinForms.Guna2Button();
            this.txtNumberPhonSupp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserNameSupp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdSupp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddSupp = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTopSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.pnlDownSupp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopSup
            // 
            this.pnlTopSup.BackColor = System.Drawing.Color.White;
            this.pnlTopSup.BorderColor = System.Drawing.Color.White;
            this.pnlTopSup.Controls.Add(this.txtSearch);
            this.pnlTopSup.Controls.Add(this.lblSupplierList);
            this.pnlTopSup.Controls.Add(this.sprGaris);
            this.pnlTopSup.Controls.Add(this.dgvSupplier);
            this.pnlTopSup.Location = new System.Drawing.Point(32, 25);
            this.pnlTopSup.Name = "pnlTopSup";
            this.pnlTopSup.Size = new System.Drawing.Size(1173, 380);
            this.pnlTopSup.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.SystemColors.Control;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(767, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(384, 42);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierList.Location = new System.Drawing.Point(21, 45);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(144, 26);
            this.lblSupplierList.TabIndex = 10;
            this.lblSupplierList.Text = "Supplier List";
            // 
            // sprGaris
            // 
            this.sprGaris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.sprGaris.FillThickness = 5;
            this.sprGaris.Location = new System.Drawing.Point(25, 77);
            this.sprGaris.Name = "sprGaris";
            this.sprGaris.Size = new System.Drawing.Size(1126, 10);
            this.sprGaris.TabIndex = 7;
            // 
            // dgvSupplier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.ColumnHeadersHeight = 28;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplier.Location = new System.Drawing.Point(25, 95);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(1126, 264);
            this.dgvSupplier.TabIndex = 4;
            this.dgvSupplier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplier.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSupplier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSupplier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSupplier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSupplier.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSupplier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupplier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSupplier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSupplier.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvSupplier.ThemeStyle.ReadOnly = false;
            this.dgvSupplier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupplier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSupplier.ThemeStyle.RowsStyle.Height = 28;
            this.dgvSupplier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            // 
            // pnlDownSupp
            // 
            this.pnlDownSupp.BackColor = System.Drawing.Color.White;
            this.pnlDownSupp.BorderColor = System.Drawing.Color.White;
            this.pnlDownSupp.Controls.Add(this.btnBack);
            this.pnlDownSupp.Controls.Add(this.btnClearSupp);
            this.pnlDownSupp.Controls.Add(this.btnDeleteSupp);
            this.pnlDownSupp.Controls.Add(this.btnUpdateSupp);
            this.pnlDownSupp.Controls.Add(this.txtNumberPhonSupp);
            this.pnlDownSupp.Controls.Add(this.txtUserNameSupp);
            this.pnlDownSupp.Controls.Add(this.txtIdSupp);
            this.pnlDownSupp.Controls.Add(this.btnAddSupp);
            this.pnlDownSupp.Location = new System.Drawing.Point(32, 430);
            this.pnlDownSupp.Name = "pnlDownSupp";
            this.pnlDownSupp.Size = new System.Drawing.Size(1173, 260);
            this.pnlDownSupp.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::fashionStoreInventoryManajement.Properties.Resources.icons8_back_50;
            this.btnBack.Location = new System.Drawing.Point(25, 202);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(47, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnClearSupp
            // 
            this.btnClearSupp.BackColor = System.Drawing.Color.White;
            this.btnClearSupp.BorderRadius = 10;
            this.btnClearSupp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearSupp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearSupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnClearSupp.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSupp.ForeColor = System.Drawing.Color.White;
            this.btnClearSupp.Location = new System.Drawing.Point(850, 154);
            this.btnClearSupp.Name = "btnClearSupp";
            this.btnClearSupp.Size = new System.Drawing.Size(161, 45);
            this.btnClearSupp.TabIndex = 6;
            this.btnClearSupp.Text = "CLEAR";
            this.btnClearSupp.Click += new System.EventHandler(this.btnClearSupp_Click);
            this.btnClearSupp.MouseEnter += new System.EventHandler(this.btnClearSupp_MouseEnter);
            this.btnClearSupp.MouseLeave += new System.EventHandler(this.btnClearSupp_MouseLeave);
            // 
            // btnDeleteSupp
            // 
            this.btnDeleteSupp.BackColor = System.Drawing.Color.White;
            this.btnDeleteSupp.BorderRadius = 10;
            this.btnDeleteSupp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSupp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnDeleteSupp.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupp.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSupp.Location = new System.Drawing.Point(612, 154);
            this.btnDeleteSupp.Name = "btnDeleteSupp";
            this.btnDeleteSupp.Size = new System.Drawing.Size(161, 45);
            this.btnDeleteSupp.TabIndex = 5;
            this.btnDeleteSupp.Text = "DELETE";
            this.btnDeleteSupp.Click += new System.EventHandler(this.btnDeleteSupp_Click);
            this.btnDeleteSupp.MouseEnter += new System.EventHandler(this.btnDeleteSupp_MouseEnter);
            this.btnDeleteSupp.MouseLeave += new System.EventHandler(this.btnDeleteSupp_MouseLeave);
            // 
            // btnUpdateSupp
            // 
            this.btnUpdateSupp.BackColor = System.Drawing.Color.White;
            this.btnUpdateSupp.BorderRadius = 10;
            this.btnUpdateSupp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSupp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateSupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnUpdateSupp.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupp.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSupp.Location = new System.Drawing.Point(374, 154);
            this.btnUpdateSupp.Name = "btnUpdateSupp";
            this.btnUpdateSupp.Size = new System.Drawing.Size(161, 45);
            this.btnUpdateSupp.TabIndex = 4;
            this.btnUpdateSupp.Text = "UPDATE";
            this.btnUpdateSupp.Click += new System.EventHandler(this.btnUpdateSupp_Click);
            this.btnUpdateSupp.MouseEnter += new System.EventHandler(this.btnUpdateSupp_MouseEnter);
            this.btnUpdateSupp.MouseLeave += new System.EventHandler(this.btnUpdateSupp_MouseLeave);
            // 
            // txtNumberPhonSupp
            // 
            this.txtNumberPhonSupp.AutoRoundedCorners = true;
            this.txtNumberPhonSupp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtNumberPhonSupp.BorderRadius = 20;
            this.txtNumberPhonSupp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhonSupp.DefaultText = "";
            this.txtNumberPhonSupp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberPhonSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberPhonSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhonSupp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhonSupp.FillColor = System.Drawing.SystemColors.Control;
            this.txtNumberPhonSupp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhonSupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberPhonSupp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhonSupp.Location = new System.Drawing.Point(802, 45);
            this.txtNumberPhonSupp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberPhonSupp.Name = "txtNumberPhonSupp";
            this.txtNumberPhonSupp.PasswordChar = '\0';
            this.txtNumberPhonSupp.PlaceholderText = "";
            this.txtNumberPhonSupp.SelectedText = "";
            this.txtNumberPhonSupp.Size = new System.Drawing.Size(206, 42);
            this.txtNumberPhonSupp.TabIndex = 3;
            // 
            // txtUserNameSupp
            // 
            this.txtUserNameSupp.AutoRoundedCorners = true;
            this.txtUserNameSupp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtUserNameSupp.BorderRadius = 20;
            this.txtUserNameSupp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameSupp.DefaultText = "";
            this.txtUserNameSupp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameSupp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameSupp.FillColor = System.Drawing.SystemColors.Control;
            this.txtUserNameSupp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameSupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserNameSupp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameSupp.Location = new System.Drawing.Point(471, 45);
            this.txtUserNameSupp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameSupp.Name = "txtUserNameSupp";
            this.txtUserNameSupp.PasswordChar = '\0';
            this.txtUserNameSupp.PlaceholderText = "";
            this.txtUserNameSupp.SelectedText = "";
            this.txtUserNameSupp.Size = new System.Drawing.Size(206, 42);
            this.txtUserNameSupp.TabIndex = 2;
            // 
            // txtIdSupp
            // 
            this.txtIdSupp.AutoRoundedCorners = true;
            this.txtIdSupp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtIdSupp.BorderRadius = 20;
            this.txtIdSupp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdSupp.DefaultText = "";
            this.txtIdSupp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdSupp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdSupp.FillColor = System.Drawing.SystemColors.Control;
            this.txtIdSupp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdSupp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdSupp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdSupp.Location = new System.Drawing.Point(151, 45);
            this.txtIdSupp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdSupp.Name = "txtIdSupp";
            this.txtIdSupp.PasswordChar = '\0';
            this.txtIdSupp.PlaceholderText = "";
            this.txtIdSupp.SelectedText = "";
            this.txtIdSupp.Size = new System.Drawing.Size(206, 42);
            this.txtIdSupp.TabIndex = 1;
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.BackColor = System.Drawing.Color.White;
            this.btnAddSupp.BorderRadius = 10;
            this.btnAddSupp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSupp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSupp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnAddSupp.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupp.ForeColor = System.Drawing.Color.White;
            this.btnAddSupp.Location = new System.Drawing.Point(151, 154);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(161, 45);
            this.btnAddSupp.TabIndex = 0;
            this.btnAddSupp.Text = "ADD";
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            this.btnAddSupp.MouseEnter += new System.EventHandler(this.btnAddSupp_MouseEnter);
            this.btnAddSupp.MouseLeave += new System.EventHandler(this.btnAddSupp_MouseLeave);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 713);
            this.Controls.Add(this.pnlDownSupp);
            this.Controls.Add(this.pnlTopSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.pnlTopSup.ResumeLayout(false);
            this.pnlTopSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.pnlDownSupp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopSup;
        private Guna.UI2.WinForms.Guna2Panel pnlDownSupp;
        private Guna.UI2.WinForms.Guna2Button btnAddSupp;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberPhonSupp;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameSupp;
        private Guna.UI2.WinForms.Guna2TextBox txtIdSupp;
        private Guna.UI2.WinForms.Guna2Button btnUpdateSupp;
        private Guna.UI2.WinForms.Guna2Button btnClearSupp;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSupp;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSupplier;
        private Guna.UI2.WinForms.Guna2Separator sprGaris;
        private System.Windows.Forms.Label lblSupplierList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}