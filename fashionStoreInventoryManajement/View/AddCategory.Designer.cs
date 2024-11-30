namespace fashionStoreInventoryManajement.View
{
    partial class AddCategory
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnDesainCategory = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtNameCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.txtIDCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDCategory = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.pnlTop.Controls.Add(this.lblCategory);
            this.pnlTop.Controls.Add(this.btnDesainCategory);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(543, 106);
            this.pnlTop.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(127, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(161, 25);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Detail Category";
            // 
            // btnDesainCategory
            // 
            this.btnDesainCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnDesainCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesainCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesainCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesainCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesainCategory.FillColor = System.Drawing.Color.White;
            this.btnDesainCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesainCategory.ForeColor = System.Drawing.Color.White;
            this.btnDesainCategory.Image = global::fashionStoreInventoryManajement.Properties.Resources.icons8_christmas_penguin_100;
            this.btnDesainCategory.ImageSize = new System.Drawing.Size(60, 60);
            this.btnDesainCategory.Location = new System.Drawing.Point(25, 14);
            this.btnDesainCategory.Name = "btnDesainCategory";
            this.btnDesainCategory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDesainCategory.Size = new System.Drawing.Size(73, 75);
            this.btnDesainCategory.TabIndex = 6;
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.BackColor = System.Drawing.Color.White;
            this.lblAddCategory.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblAddCategory.Location = new System.Drawing.Point(168, 143);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(224, 35);
            this.lblAddCategory.TabIndex = 21;
            this.lblAddCategory.Text = "Add Category";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BorderRadius = 10;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(313, 428);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(156, 39);
            this.btnAddCustomer.TabIndex = 26;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Tomato;
            this.btnClose.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(63, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 39);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.AutoRoundedCorners = true;
            this.txtNameCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtNameCategory.BorderRadius = 18;
            this.txtNameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCategory.DefaultText = "";
            this.txtNameCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCategory.FillColor = System.Drawing.SystemColors.Control;
            this.txtNameCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameCategory.Location = new System.Drawing.Point(182, 314);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.PasswordChar = '\0';
            this.txtNameCategory.PlaceholderText = "";
            this.txtNameCategory.SelectedText = "";
            this.txtNameCategory.Size = new System.Drawing.Size(287, 39);
            this.txtNameCategory.TabIndex = 22;
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblNameCategory.Location = new System.Drawing.Point(59, 323);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(62, 21);
            this.lblNameCategory.TabIndex = 20;
            this.lblNameCategory.Text = "Name";
            // 
            // txtIDCategory
            // 
            this.txtIDCategory.AutoRoundedCorners = true;
            this.txtIDCategory.BackColor = System.Drawing.Color.White;
            this.txtIDCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtIDCategory.BorderRadius = 18;
            this.txtIDCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDCategory.DefaultText = "";
            this.txtIDCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDCategory.FillColor = System.Drawing.SystemColors.Control;
            this.txtIDCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDCategory.Location = new System.Drawing.Point(182, 233);
            this.txtIDCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDCategory.Name = "txtIDCategory";
            this.txtIDCategory.PasswordChar = '\0';
            this.txtIDCategory.PlaceholderText = "";
            this.txtIDCategory.SelectedText = "";
            this.txtIDCategory.Size = new System.Drawing.Size(287, 39);
            this.txtIDCategory.TabIndex = 19;
            // 
            // lblIDCategory
            // 
            this.lblIDCategory.AutoSize = true;
            this.lblIDCategory.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblIDCategory.Location = new System.Drawing.Point(59, 242);
            this.lblIDCategory.Name = "lblIDCategory";
            this.lblIDCategory.Size = new System.Drawing.Size(34, 23);
            this.lblIDCategory.TabIndex = 18;
            this.lblIDCategory.Text = "ID";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 523);
            this.Controls.Add(this.lblAddCategory);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIDCategory);
            this.Controls.Add(this.txtIDCategory);
            this.Controls.Add(this.lblNameCategory);
            this.Controls.Add(this.txtNameCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2CircleButton btnDesainCategory;
        private System.Windows.Forms.Label lblAddCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtNameCategory;
        private System.Windows.Forms.Label lblNameCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtIDCategory;
        private System.Windows.Forms.Label lblIDCategory;
    }
}