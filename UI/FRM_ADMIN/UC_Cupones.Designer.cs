namespace UI.FRM_ADMIN
{
    partial class UC_Cupones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCrearCodigo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnCrearCupon = new Guna.UI2.WinForms.Guna2Button();
            this.CbxIDDesc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // BtnCrearCodigo
            // 
            this.BtnCrearCodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearCodigo.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCodigo.Location = new System.Drawing.Point(351, 73);
            this.BtnCrearCodigo.Name = "BtnCrearCodigo";
            this.BtnCrearCodigo.Size = new System.Drawing.Size(141, 36);
            this.BtnCrearCodigo.TabIndex = 0;
            this.BtnCrearCodigo.Text = "Generar Codigo";
            this.BtnCrearCodigo.Click += new System.EventHandler(this.BtnCrearCodigo_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 94);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Codigo de cupon:";
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxCodigo.DefaultText = "";
            this.TbxCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxCodigo.Location = new System.Drawing.Point(110, 73);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.PasswordChar = '\0';
            this.TbxCodigo.PlaceholderText = "";
            this.TbxCodigo.ReadOnly = true;
            this.TbxCodigo.SelectedText = "";
            this.TbxCodigo.Size = new System.Drawing.Size(200, 36);
            this.TbxCodigo.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 149);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Descuento (%):";
            // 
            // BtnCrearCupon
            // 
            this.BtnCrearCupon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCupon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCupon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearCupon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearCupon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearCupon.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCupon.Location = new System.Drawing.Point(120, 203);
            this.BtnCrearCupon.Name = "BtnCrearCupon";
            this.BtnCrearCupon.Size = new System.Drawing.Size(180, 45);
            this.BtnCrearCupon.TabIndex = 5;
            this.BtnCrearCupon.Text = "Crear cupon";
            this.BtnCrearCupon.Click += new System.EventHandler(this.BtnCrearCupon_Click);
            // 
            // CbxIDDesc
            // 
            this.CbxIDDesc.BackColor = System.Drawing.Color.Transparent;
            this.CbxIDDesc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxIDDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxIDDesc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxIDDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxIDDesc.ItemHeight = 30;
            this.CbxIDDesc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CbxIDDesc.Location = new System.Drawing.Point(110, 128);
            this.CbxIDDesc.Name = "CbxIDDesc";
            this.CbxIDDesc.Size = new System.Drawing.Size(200, 36);
            this.CbxIDDesc.TabIndex = 6;
            // 
            // UC_Cupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbxIDDesc);
            this.Controls.Add(this.BtnCrearCupon);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnCrearCodigo);
            this.Name = "UC_Cupones";
            this.Size = new System.Drawing.Size(629, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnCrearCodigo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbxCodigo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button BtnCrearCupon;
        private Guna.UI2.WinForms.Guna2ComboBox CbxIDDesc;
    }
}
