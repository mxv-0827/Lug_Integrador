
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnLogeo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxContra = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnRegistro = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogeo
            // 
            this.BtnLogeo.BorderRadius = 3;
            this.BtnLogeo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogeo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogeo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogeo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogeo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogeo.FillColor = System.Drawing.Color.Red;
            this.BtnLogeo.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogeo.ForeColor = System.Drawing.Color.White;
            this.BtnLogeo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLogeo.Location = new System.Drawing.Point(454, 216);
            this.BtnLogeo.Name = "BtnLogeo";
            this.BtnLogeo.Size = new System.Drawing.Size(108, 36);
            this.BtnLogeo.TabIndex = 0;
            this.BtnLogeo.Text = "Iniciar sesion";
            this.BtnLogeo.Click += new System.EventHandler(this.BtnLogeo_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(362, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(35, 15);
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
            this.TbxEmail.Location = new System.Drawing.Point(362, 64);
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
            this.TbxContra.Location = new System.Drawing.Point(362, 149);
            this.TbxContra.Name = "TbxContra";
            this.TbxContra.PasswordChar = '●';
            this.TbxContra.PlaceholderText = "";
            this.TbxContra.SelectedText = "";
            this.TbxContra.Size = new System.Drawing.Size(200, 36);
            this.TbxContra.TabIndex = 4;
            this.TbxContra.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(362, 128);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Contraseña:";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.BackColor = System.Drawing.Color.Black;
            this.BtnRegistro.BorderRadius = 3;
            this.BtnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegistro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegistro.FillColor = System.Drawing.Color.Red;
            this.BtnRegistro.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnRegistro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRegistro.Location = new System.Drawing.Point(545, 321);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(104, 36);
            this.BtnRegistro.TabIndex = 5;
            this.BtnRegistro.Text = "Registrarse";
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(265, 369);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 330F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 64);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(237, 231);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(661, 369);
            this.Controls.Add(this.BtnLogeo);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.TbxContra);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

