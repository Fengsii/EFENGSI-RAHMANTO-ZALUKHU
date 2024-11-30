namespace fashionStoreInventoryManajement.View
{
    partial class Category
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
            this.pnlTopCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSupplierList = new System.Windows.Forms.Label();
            this.sprGaris = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvCategoryy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlDownCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClearCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCategory = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserNameCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTopCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryy)).BeginInit();
            this.pnlDownCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopCategory
            // 
            this.pnlTopCategory.BackColor = System.Drawing.Color.White;
            this.pnlTopCategory.BorderColor = System.Drawing.Color.White;
            this.pnlTopCategory.Controls.Add(this.txtSearch);
            this.pnlTopCategory.Controls.Add(this.lblSupplierList);
            this.pnlTopCategory.Controls.Add(this.sprGaris);
            this.pnlTopCategory.Controls.Add(this.dgvCategoryy);
            this.pnlTopCategory.Location = new System.Drawing.Point(32, 25);
            this.pnlTopCategory.Name = "pnlTopCategory";
            this.pnlTopCategory.Size = new System.Drawing.Size(1173, 398);
            this.pnlTopCategory.TabIndex = 2;
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
            this.txtSearch.Location = new System.Drawing.Point(767, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(384, 42);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierList.Location = new System.Drawing.Point(21, 44);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(147, 26);
            this.lblSupplierList.TabIndex = 13;
            this.lblSupplierList.Text = "Category List";
            // 
            // sprGaris
            // 
            this.sprGaris.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.sprGaris.FillThickness = 5;
            this.sprGaris.Location = new System.Drawing.Point(25, 76);
            this.sprGaris.Name = "sprGaris";
            this.sprGaris.Size = new System.Drawing.Size(1126, 10);
            this.sprGaris.TabIndex = 11;
            // 
            // dgvCategoryy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCategoryy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoryy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoryy.ColumnHeadersHeight = 28;
            this.dgvCategoryy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoryy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategoryy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategoryy.Location = new System.Drawing.Point(25, 93);
            this.dgvCategoryy.Name = "dgvCategoryy";
            this.dgvCategoryy.RowHeadersVisible = false;
            this.dgvCategoryy.RowHeadersWidth = 62;
            this.dgvCategoryy.RowTemplate.Height = 28;
            this.dgvCategoryy.Size = new System.Drawing.Size(1126, 282);
            this.dgvCategoryy.TabIndex = 4;
            this.dgvCategoryy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoryy.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategoryy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategoryy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategoryy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategoryy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoryy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategoryy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCategoryy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategoryy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoryy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategoryy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategoryy.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvCategoryy.ThemeStyle.ReadOnly = false;
            this.dgvCategoryy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoryy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoryy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoryy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategoryy.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCategoryy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategoryy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategoryy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryy_CellClick);
            // 
            // pnlDownCategory
            // 
            this.pnlDownCategory.BackColor = System.Drawing.Color.White;
            this.pnlDownCategory.BorderColor = System.Drawing.Color.White;
            this.pnlDownCategory.Controls.Add(this.btnBack);
            this.pnlDownCategory.Controls.Add(this.btnClearCategory);
            this.pnlDownCategory.Controls.Add(this.btnDeleteCategory);
            this.pnlDownCategory.Controls.Add(this.btnUpdateCategory);
            this.pnlDownCategory.Controls.Add(this.txtUserNameCategory);
            this.pnlDownCategory.Controls.Add(this.txtIdCategory);
            this.pnlDownCategory.Controls.Add(this.btnAddCategory);
            this.pnlDownCategory.Location = new System.Drawing.Point(32, 452);
            this.pnlDownCategory.Name = "pnlDownCategory";
            this.pnlDownCategory.Size = new System.Drawing.Size(1173, 237);
            this.pnlDownCategory.TabIndex = 3;
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
            this.btnBack.Location = new System.Drawing.Point(25, 185);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(47, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.BackColor = System.Drawing.Color.White;
            this.btnClearCategory.BorderRadius = 10;
            this.btnClearCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnClearCategory.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCategory.ForeColor = System.Drawing.Color.White;
            this.btnClearCategory.Location = new System.Drawing.Point(850, 137);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(161, 45);
            this.btnClearCategory.TabIndex = 6;
            this.btnClearCategory.Text = "CLEAR";
            this.btnClearCategory.Click += new System.EventHandler(this.btnClearCategory_Click);
            this.btnClearCategory.MouseEnter += new System.EventHandler(this.btnClearCategory_MouseEnter);
            this.btnClearCategory.MouseLeave += new System.EventHandler(this.btnClearCategory_MouseLeave);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.White;
            this.btnDeleteCategory.BorderRadius = 10;
            this.btnDeleteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnDeleteCategory.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(612, 137);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(161, 45);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "DELETE";
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            this.btnDeleteCategory.MouseEnter += new System.EventHandler(this.btnDeleteCategory_MouseEnter);
            this.btnDeleteCategory.MouseLeave += new System.EventHandler(this.btnDeleteCategory_MouseLeave);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.White;
            this.btnUpdateCategory.BorderRadius = 10;
            this.btnUpdateCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnUpdateCategory.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(374, 137);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(161, 45);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "UPDATE";
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            this.btnUpdateCategory.MouseEnter += new System.EventHandler(this.btnUpdateCategory_MouseEnter);
            this.btnUpdateCategory.MouseLeave += new System.EventHandler(this.btnUpdateCategory_MouseLeave);
            // 
            // txtUserNameCategory
            // 
            this.txtUserNameCategory.AutoRoundedCorners = true;
            this.txtUserNameCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtUserNameCategory.BorderRadius = 20;
            this.txtUserNameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameCategory.DefaultText = "";
            this.txtUserNameCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameCategory.FillColor = System.Drawing.SystemColors.Control;
            this.txtUserNameCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserNameCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameCategory.Location = new System.Drawing.Point(612, 41);
            this.txtUserNameCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameCategory.Name = "txtUserNameCategory";
            this.txtUserNameCategory.PasswordChar = '\0';
            this.txtUserNameCategory.PlaceholderText = "";
            this.txtUserNameCategory.SelectedText = "";
            this.txtUserNameCategory.Size = new System.Drawing.Size(206, 42);
            this.txtUserNameCategory.TabIndex = 2;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.AutoRoundedCorners = true;
            this.txtIdCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtIdCategory.BorderRadius = 20;
            this.txtIdCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCategory.DefaultText = "";
            this.txtIdCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCategory.FillColor = System.Drawing.SystemColors.Control;
            this.txtIdCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCategory.Location = new System.Drawing.Point(329, 41);
            this.txtIdCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.PasswordChar = '\0';
            this.txtIdCategory.PlaceholderText = "";
            this.txtIdCategory.SelectedText = "";
            this.txtIdCategory.Size = new System.Drawing.Size(206, 42);
            this.txtIdCategory.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.BorderRadius = 10;
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(151, 137);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(161, 45);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "ADD";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            this.btnAddCategory.MouseEnter += new System.EventHandler(this.btnAddCategory_MouseEnter);
            this.btnAddCategory.MouseLeave += new System.EventHandler(this.btnAddCategory_MouseLeave);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 713);
            this.Controls.Add(this.pnlDownCategory);
            this.Controls.Add(this.pnlTopCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.pnlTopCategory.ResumeLayout(false);
            this.pnlTopCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryy)).EndInit();
            this.pnlDownCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopCategory;
        private Guna.UI2.WinForms.Guna2Panel pnlDownCategory;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnClearCategory;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCategory;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategoryy;
        private System.Windows.Forms.Label lblSupplierList;
        private Guna.UI2.WinForms.Guna2Separator sprGaris;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}