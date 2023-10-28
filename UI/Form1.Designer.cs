
namespace UI
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogeo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxContra = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnRegistro = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BtnLogeo
            // 
            this.BtnLogeo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogeo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogeo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogeo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogeo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLogeo.ForeColor = System.Drawing.Color.White;
            this.BtnLogeo.Location = new System.Drawing.Point(418, 271);
            this.BtnLogeo.Name = "BtnLogeo";
            this.BtnLogeo.Size = new System.Drawing.Size(180, 45);
            this.BtnLogeo.TabIndex = 0;
            this.BtnLogeo.Text = "INICIAR SESION";
            this.BtnLogeo.Click += new System.EventHandler(this.BtnLogeo_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(272, 139);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(31, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Email:";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxEmail.DefaultText = "";
            this.TbxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxEmail.Location = new System.Drawing.Point(309, 118);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.PasswordChar = '\0';
            this.TbxEmail.PlaceholderText = "";
            this.TbxEmail.SelectedText = "";
            this.TbxEmail.Size = new System.Drawing.Size(200, 36);
            this.TbxEmail.TabIndex = 2;
            // 
            // TbxContra
            // 
            this.TbxContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxContra.DefaultText = "";
            this.TbxContra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxContra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxContra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxContra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxContra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxContra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxContra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxContra.Location = new System.Drawing.Point(309, 182);
            this.TbxContra.Name = "TbxContra";
            this.TbxContra.PasswordChar = '\0';
            this.TbxContra.PlaceholderText = "";
            this.TbxContra.SelectedText = "";
            this.TbxContra.Size = new System.Drawing.Size(200, 36);
            this.TbxContra.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(243, 203);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Contraseña:";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegistro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnRegistro.Location = new System.Drawing.Point(204, 271);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(180, 45);
            this.BtnRegistro.TabIndex = 5;
            this.BtnRegistro.Text = "REGISTRARSE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.TbxContra);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnLogeo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnLogeo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TbxContra;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button BtnRegistro;
    }
}

