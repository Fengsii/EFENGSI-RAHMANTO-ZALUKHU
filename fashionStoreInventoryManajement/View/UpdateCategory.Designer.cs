namespace fashionStoreInventoryManajement.View
{
    partial class UpdateCategory
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
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblIDCategory = new System.Windows.Forms.Label();
            this.txtIDUpdateCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.txtUpdateNameCategory = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.lblCategory.TabIndex = 9;
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
            this.btnDesainCategory.TabIndex = 8;
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.BackColor = System.Drawing.Color.White;
            this.lblUpdateCategory.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblUpdateCategory.Location = new System.Drawing.Point(133, 147);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(292, 35);
            this.lblUpdateCategory.TabIndex = 30;
            this.lblUpdateCategory.Text = "Upadate Category";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BorderRadius = 10;
            this.btnUpdateCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(317, 432);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(156, 39);
            this.btnUpdateCustomer.TabIndex = 33;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
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
            this.btnClose.Location = new System.Drawing.Point(67, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 39);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblIDCategory
            // 
            this.lblIDCategory.AutoSize = true;
            this.lblIDCategory.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblIDCategory.Location = new System.Drawing.Point(63, 246);
            this.lblIDCategory.Name = "lblIDCategory";
            this.lblIDCategory.Size = new System.Drawing.Size(34, 23);
            this.lblIDCategory.TabIndex = 27;
            this.lblIDCategory.Text = "ID";
            // 
            // txtIDUpdateCategory
            // 
            this.txtIDUpdateCategory.AutoRoundedCorners = true;
            this.txtIDUpdateCategory.BackColor = System.Drawing.Color.White;
            this.txtIDUpdateCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtIDUpdateCategory.BorderRadius = 18;
            this.txtIDUpdateCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDUpdateCategory.DefaultText = "";
            this.txtIDUpdateCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDUpdateCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDUpdateCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDUpdateCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDUpdateCategory.FillColor = System.Drawing.SystemColors.Control;
            this.txtIDUpdateCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDUpdateCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDUpdateCategory.Location = new System.Drawing.Point(186, 237);
            this.txtIDUpdateCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDUpdateCategory.Name = "txtIDUpdateCategory";
            this.txtIDUpdateCategory.PasswordChar = '\0';
            this.txtIDUpdateCategory.PlaceholderText = "";
            this.txtIDUpdateCategory.SelectedText = "";
            this.txtIDUpdateCategory.Size = new System.Drawing.Size(287, 39);
            this.txtIDUpdateCategory.TabIndex = 28;
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.lblNameCategory.Location = new System.Drawing.Point(63, 327);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(62, 21);
            this.lblNameCategory.TabIndex = 29;
            this.lblNameCategory.Text = "Name";
            // 
            // txtUpdateNameCategory
            // 
            this.txtUpdateNameCategory.AutoRoundedCorners = true;
            this.txtUpdateNameCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(167)))));
            this.txtUpdateNameCategory.BorderRadius = 18;
            this.txtUpdateNameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateNameCategory.DefaultText = "";
            this.txtUpdateNameCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpdateNameCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpdateNameCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateNameCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpdateNameCategory.FillColor = System.Drawing.SystemColors.Control;
            this.txtUpdateNameCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateNameCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpdateNameCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpdateNameCategory.Location = new System.Drawing.Point(186, 318);
            this.txtUpdateNameCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateNameCategory.Name = "txtUpdateNameCategory";
            this.txtUpdateNameCategory.PasswordChar = '\0';
            this.txtUpdateNameCategory.PlaceholderText = "";
            this.txtUpdateNameCategory.SelectedText = "";
            this.txtUpdateNameCategory.Size = new System.Drawing.Size(287, 39);
            this.txtUpdateNameCategory.TabIndex = 31;
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 523);
            this.Controls.Add(this.lblUpdateCategory);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIDCategory);
            this.Controls.Add(this.txtIDUpdateCategory);
            this.Controls.Add(this.lblNameCategory);
            this.Controls.Add(this.txtUpdateNameCategory);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2CircleButton btnDesainCategory;
        private System.Windows.Forms.Label lblUpdateCategory;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCustomer;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblIDCategory;
        private System.Windows.Forms.Label lblNameCategory;
        public Guna.UI2.WinForms.Guna2TextBox txtIDUpdateCategory;
        public Guna.UI2.WinForms.Guna2TextBox txtUpdateNameCategory;
    }
}