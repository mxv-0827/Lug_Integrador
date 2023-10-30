namespace UI.FRM_ADMIN
{
    partial class UC_Salas
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
            this.BtnCrearSala = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxCapacidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // BtnCrearSala
            // 
            this.BtnCrearSala.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearSala.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearSala.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearSala.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearSala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearSala.ForeColor = System.Drawing.Color.White;
            this.BtnCrearSala.Location = new System.Drawing.Point(218, 94);
            this.BtnCrearSala.Name = "BtnCrearSala";
            this.BtnCrearSala.Size = new System.Drawing.Size(180, 45);
            this.BtnCrearSala.TabIndex = 0;
            this.BtnCrearSala.Text = "CREAR SALA";
            this.BtnCrearSala.Click += new System.EventHandler(this.BtnCrearSala_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(157, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Nombre de la sala:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxNombre.DefaultText = "";
            this.TbxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNombre.Location = new System.Drawing.Point(103, 52);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.PasswordChar = '\0';
            this.TbxNombre.PlaceholderText = "";
            this.TbxNombre.SelectedText = "";
            this.TbxNombre.Size = new System.Drawing.Size(200, 36);
            this.TbxNombre.TabIndex = 2;
            // 
            // TbxCapacidad
            // 
            this.TbxCapacidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxCapacidad.DefaultText = "";
            this.TbxCapacidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxCapacidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxCapacidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxCapacidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxCapacidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxCapacidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxCapacidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxCapacidad.Location = new System.Drawing.Point(309, 52);
            this.TbxCapacidad.Name = "TbxCapacidad";
            this.TbxCapacidad.PasswordChar = '\0';
            this.TbxCapacidad.PlaceholderText = "";
            this.TbxCapacidad.SelectedText = "";
            this.TbxCapacidad.Size = new System.Drawing.Size(200, 36);
            this.TbxCapacidad.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(383, 31);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Capacidad:";
            // 
            // UC_Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbxCapacidad);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnCrearSala);
            this.Name = "UC_Salas";
            this.Size = new System.Drawing.Size(629, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnCrearSala;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbxNombre;
        private Guna.UI2.WinForms.Guna2TextBox TbxCapacidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
