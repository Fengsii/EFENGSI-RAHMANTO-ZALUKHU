namespace fashionStoreInventoryManajement.View
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            this.btnDesainDua = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.prbLoading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.lblPersentase = new System.Windows.Forms.Label();
            this.lblPersenn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDesainDua
            // 
            this.btnDesainDua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesainDua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesainDua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesainDua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesainDua.FillColor = System.Drawing.Color.White;
            this.btnDesainDua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesainDua.ForeColor = System.Drawing.Color.White;
            this.btnDesainDua.Location = new System.Drawing.Point(-12, 450);
            this.btnDesainDua.Name = "btnDesainDua";
            this.btnDesainDua.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDesainDua.Size = new System.Drawing.Size(896, 293);
            this.btnDesainDua.TabIndex = 1;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(136)))), ((int)(((byte)(113)))));
            this.lblTema.Location = new System.Drawing.Point(150, 44);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(610, 41);
            this.lblTema.TabIndex = 13;
            this.lblTema.Text = "Store Inventory Manajemet System";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.lblBrand.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(136)))), ((int)(((byte)(113)))));
            this.lblBrand.Location = new System.Drawing.Point(340, 217);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(238, 35);
            this.lblBrand.TabIndex = 14;
            this.lblBrand.Text = "Fashion Store";
            // 
            // prbLoading
            // 
            this.prbLoading.Location = new System.Drawing.Point(241, 299);
            this.prbLoading.Name = "prbLoading";
            this.prbLoading.Size = new System.Drawing.Size(426, 30);
            this.prbLoading.TabIndex = 15;
            this.prbLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // lblPersentase
            // 
            this.lblPersentase.AutoSize = true;
            this.lblPersentase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersentase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(77)))));
            this.lblPersentase.Location = new System.Drawing.Point(454, 342);
            this.lblPersentase.Name = "lblPersentase";
            this.lblPersentase.Size = new System.Drawing.Size(0, 29);
            this.lblPersentase.TabIndex = 16;
            // 
            // lblPersenn
            // 
            this.lblPersenn.AutoSize = true;
            this.lblPersenn.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersenn.ForeColor = System.Drawing.Color.Tomato;
            this.lblPersenn.Location = new System.Drawing.Point(422, 345);
            this.lblPersenn.Name = "lblPersenn";
            this.lblPersenn.Size = new System.Drawing.Size(32, 26);
            this.lblPersenn.TabIndex = 17;
            this.lblPersenn.Text = "%";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(872, 585);
            this.Controls.Add(this.lblPersenn);
            this.Controls.Add(this.lblPersentase);
            this.Controls.Add(this.prbLoading);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.btnDesainDua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnDesainDua;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI2.WinForms.Guna2ProgressBar prbLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Label lblPersentase;
        private System.Windows.Forms.Label lblPersenn;
    }
}