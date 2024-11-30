namespace fashionStoreInventoryManajement.View
{
    partial class Customers
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
            this.lblCustomersList = new System.Windows.Forms.Label();
            this.sprGaris = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvCustomerss = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlDownCustomers = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClearCustom = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCustom = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCustom = new Guna.UI2.WinForms.Guna2Button();
            this.txtNumberPhonCustom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserNameCustom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdCustom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCustom = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTopSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerss)).BeginInit();
            this.pnlDownCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopSup
            // 
            this.pnlTopSup.BackColor = System.Drawing.Color.White;
            this.pnlTopSup.BorderColor = System.Drawing.Color.White;
            this.pnlTopSup.Controls.Add(this.txtSearch);
            this.pnlTopSup.Controls.Add(this.lblCustomersList);
            this.pnlTopSup.Controls.Add(this.sprGaris);
            this.pnlTopSup.Controls.Add(this.dgvCustomerss);
            this.pnlTopSup.Location = new System.Drawing.Point(32, 25);
            this.pnlTopSup.Name = "pnlTopSup";
            this.pnlTopSup.Size = new System.Drawing.Size(1173, 382);
            this.pnlTopSup.TabIndex = 1;
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
            this.txtSearch.Location = new System.Drawing.Point(767, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(384, 42);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCustomersList
            // 
            this.lblCustomersList.AutoSize = true;
            this.lblCustomersList.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersList.Location = new System.Drawing.Point(20, 38);
            this.lblCustomersList.Name = "lblCustomersList";
            this.lblCustomersList.Size = new System.Drawing.Size(156, 26);
            this.lblCustomersList.TabIndex = 13;
            this.lblCustomersList.Text = "Customer List";
            // 
            // sprGaris
            // 
            this.sprGaris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.sprGaris.FillThickness = 5;
            this.sprGaris.Location = new System.Drawing.Point(24, 70);
            this.sprGaris.Name = "sprGaris";
            this.sprGaris.Size = new System.Drawing.Size(1126, 10);
            this.sprGaris.TabIndex = 11;
            // 
            // dgvCustomerss
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomerss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerss.ColumnHeadersHeight = 28;
            this.dgvCustomerss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerss.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerss.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerss.Location = new System.Drawing.Point(25, 88);
            this.dgvCustomerss.Name = "dgvCustomerss";
            this.dgvCustomerss.RowHeadersVisible = false;
            this.dgvCustomerss.RowHeadersWidth = 62;
            this.dgvCustomerss.RowTemplate.Height = 28;
            this.dgvCustomerss.Size = new System.Drawing.Size(1126, 276);
            this.dgvCustomerss.TabIndex = 4;
            this.dgvCustomerss.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerss.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomerss.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerss.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomerss.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerss.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerss.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerss.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomerss.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomerss.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerss.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomerss.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerss.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvCustomerss.ThemeStyle.ReadOnly = false;
            this.dgvCustomerss.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerss.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerss.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerss.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerss.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCustomerss.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerss.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerss_CellClick);
            // 
            // pnlDownCustomers
            // 
            this.pnlDownCustomers.BackColor = System.Drawing.Color.White;
            this.pnlDownCustomers.BorderColor = System.Drawing.Color.White;
            this.pnlDownCustomers.Controls.Add(this.btnBack);
            this.pnlDownCustomers.Controls.Add(this.btnClearCustom);
            this.pnlDownCustomers.Controls.Add(this.btnDeleteCustom);
            this.pnlDownCustomers.Controls.Add(this.btnUpdateCustom);
            this.pnlDownCustomers.Controls.Add(this.txtNumberPhonCustom);
            this.pnlDownCustomers.Controls.Add(this.txtUserNameCustom);
            this.pnlDownCustomers.Controls.Add(this.txtIdCustom);
            this.pnlDownCustomers.Controls.Add(this.btnAddCustom);
            this.pnlDownCustomers.Location = new System.Drawing.Point(32, 429);
            this.pnlDownCustomers.Name = "pnlDownCustomers";
            this.pnlDownCustomers.Size = new System.Drawing.Size(1173, 260);
            this.pnlDownCustomers.TabIndex = 2;
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
            this.btnBack.Location = new System.Drawing.Point(25, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(47, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnClearCustom
            // 
            this.btnClearCustom.BackColor = System.Drawing.Color.White;
            this.btnClearCustom.BorderRadius = 10;
            this.btnClearCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCustom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnClearCustom.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCustom.ForeColor = System.Drawing.Color.White;
            this.btnClearCustom.Location = new System.Drawing.Point(850, 153);
            this.btnClearCustom.Name = "btnClearCustom";
            this.btnClearCustom.Size = new System.Drawing.Size(161, 45);
            this.btnClearCustom.TabIndex = 6;
            this.btnClearCustom.Text = "CLEAR";
            this.btnClearCustom.Click += new System.EventHandler(this.btnClearCustom_Click);
            this.btnClearCustom.MouseEnter += new System.EventHandler(this.btnClearCustom_MouseEnter);
            this.btnClearCustom.MouseLeave += new System.EventHandler(this.btnClearCustom_MouseLeave);
            // 
            // btnDeleteCustom
            // 
            this.btnDeleteCustom.BackColor = System.Drawing.Color.White;
            this.btnDeleteCustom.BorderRadius = 10;
            this.btnDeleteCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCustom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnDeleteCustom.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustom.Location = new System.Drawing.Point(612, 153);
            this.btnDeleteCustom.Name = "btnDeleteCustom";
            this.btnDeleteCustom.Size = new System.Drawing.Size(161, 45);
            this.btnDeleteCustom.TabIndex = 5;
            this.btnDeleteCustom.Text = "DELETE";
            this.btnDeleteCustom.Click += new System.EventHandler(this.btnDeleteCustom_Click);
            this.btnDeleteCustom.MouseEnter += new System.EventHandler(this.btnDeleteCustom_MouseEnter);
            this.btnDeleteCustom.MouseLeave += new System.EventHandler(this.btnDeleteCustom_MouseLeave);
            // 
            // btnUpdateCustom
            // 
            this.btnUpdateCustom.BackColor = System.Drawing.Color.White;
            this.btnUpdateCustom.BorderRadius = 10;
            this.btnUpdateCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCustom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnUpdateCustom.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustom.Location = new System.Drawing.Point(374, 153);
            this.btnUpdateCustom.Name = "btnUpdateCustom";
            this.btnUpdateCustom.Size = new System.Drawing.Size(161, 45);
            this.btnUpdateCustom.TabIndex = 4;
            this.btnUpdateCustom.Text = "UPDATE";
            this.btnUpdateCustom.Click += new System.EventHandler(this.btnUpdateCustom_Click);
            this.btnUpdateCustom.MouseEnter += new System.EventHandler(this.btnUpdateCustom_MouseEnter);
            this.btnUpdateCustom.MouseLeave += new System.EventHandler(this.btnUpdateCustom_MouseLeave);
            // 
            // txtNumberPhonCustom
            // 
            this.txtNumberPhonCustom.AutoRoundedCorners = true;
            this.txtNumberPhonCustom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtNumberPhonCustom.BorderRadius = 20;
            this.txtNumberPhonCustom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhonCustom.DefaultText = "";
            this.txtNumberPhonCustom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberPhonCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberPhonCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhonCustom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhonCustom.FillColor = System.Drawing.SystemColors.Control;
            this.txtNumberPhonCustom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhonCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberPhonCustom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhonCustom.Location = new System.Drawing.Point(803, 47);
            this.txtNumberPhonCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberPhonCustom.Name = "txtNumberPhonCustom";
            this.txtNumberPhonCustom.PasswordChar = '\0';
            this.txtNumberPhonCustom.PlaceholderText = "";
            this.txtNumberPhonCustom.SelectedText = "";
            this.txtNumberPhonCustom.Size = new System.Drawing.Size(206, 42);
            this.txtNumberPhonCustom.TabIndex = 3;
            // 
            // txtUserNameCustom
            // 
            this.txtUserNameCustom.AutoRoundedCorners = true;
            this.txtUserNameCustom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtUserNameCustom.BorderRadius = 20;
            this.txtUserNameCustom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameCustom.DefaultText = "";
            this.txtUserNameCustom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameCustom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameCustom.FillColor = System.Drawing.SystemColors.Control;
            this.txtUserNameCustom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserNameCustom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameCustom.Location = new System.Drawing.Point(471, 47);
            this.txtUserNameCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameCustom.Name = "txtUserNameCustom";
            this.txtUserNameCustom.PasswordChar = '\0';
            this.txtUserNameCustom.PlaceholderText = "";
            this.txtUserNameCustom.SelectedText = "";
            this.txtUserNameCustom.Size = new System.Drawing.Size(206, 42);
            this.txtUserNameCustom.TabIndex = 2;
            // 
            // txtIdCustom
            // 
            this.txtIdCustom.AutoRoundedCorners = true;
            this.txtIdCustom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtIdCustom.BorderRadius = 20;
            this.txtIdCustom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCustom.DefaultText = "";
            this.txtIdCustom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustom.FillColor = System.Drawing.SystemColors.Control;
            this.txtIdCustom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCustom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustom.Location = new System.Drawing.Point(151, 47);
            this.txtIdCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCustom.Name = "txtIdCustom";
            this.txtIdCustom.PasswordChar = '\0';
            this.txtIdCustom.PlaceholderText = "";
            this.txtIdCustom.SelectedText = "";
            this.txtIdCustom.Size = new System.Drawing.Size(206, 42);
            this.txtIdCustom.TabIndex = 1;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.BackColor = System.Drawing.Color.White;
            this.btnAddCustom.BorderRadius = 10;
            this.btnAddCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnAddCustom.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustom.ForeColor = System.Drawing.Color.White;
            this.btnAddCustom.Location = new System.Drawing.Point(151, 153);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(161, 45);
            this.btnAddCustom.TabIndex = 0;
            this.btnAddCustom.Text = "ADD";
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            this.btnAddCustom.MouseEnter += new System.EventHandler(this.btnAddCustom_MouseEnter);
            this.btnAddCustom.MouseLeave += new System.EventHandler(this.btnAddCustom_MouseLeave);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 713);
            this.Controls.Add(this.pnlDownCustomers);
            this.Controls.Add(this.pnlTopSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.pnlTopSup.ResumeLayout(false);
            this.pnlTopSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerss)).EndInit();
            this.pnlDownCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopSup;
        private Guna.UI2.WinForms.Guna2Panel pnlDownCustomers;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnClearCustom;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCustom;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCustom;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameCustom;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCustom;
        private Guna.UI2.WinForms.Guna2Button btnAddCustom;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberPhonCustom;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerss;
        private System.Windows.Forms.Label lblCustomersList;
        private Guna.UI2.WinForms.Guna2Separator sprGaris;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}