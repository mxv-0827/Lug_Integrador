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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Salas));
            this.BtnCrearSala = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CterDisposicionAsientos = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.PctbxSalida = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TbxPantalla = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbxCapacidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CterDisposicionAsientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctbxSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrearSala
            // 
            this.BtnCrearSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearSala.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearSala.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearSala.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearSala.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearSala.FillColor = System.Drawing.Color.Red;
            this.BtnCrearSala.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearSala.ForeColor = System.Drawing.Color.White;
            this.BtnCrearSala.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCrearSala.Location = new System.Drawing.Point(312, 52);
            this.BtnCrearSala.Name = "BtnCrearSala";
            this.BtnCrearSala.Size = new System.Drawing.Size(103, 36);
            this.BtnCrearSala.TabIndex = 0;
            this.BtnCrearSala.Text = "Crear sala";
            this.BtnCrearSala.Click += new System.EventHandler(this.BtnCrearSala_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(102, 15);
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
            this.TbxNombre.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNombre.Location = new System.Drawing.Point(25, 52);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.PasswordChar = '\0';
            this.TbxNombre.PlaceholderText = "";
            this.TbxNombre.SelectedText = "";
            this.TbxNombre.Size = new System.Drawing.Size(141, 36);
            this.TbxNombre.TabIndex = 2;
            this.TbxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(197, 31);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Capacidad:";
            // 
            // CterDisposicionAsientos
            // 
            this.CterDisposicionAsientos.Controls.Add(this.PctbxSalida);
            this.CterDisposicionAsientos.Controls.Add(this.guna2PictureBox1);
            this.CterDisposicionAsientos.Controls.Add(this.TbxPantalla);
            this.CterDisposicionAsientos.FillColor = System.Drawing.Color.Silver;
            this.CterDisposicionAsientos.Location = new System.Drawing.Point(25, 130);
            this.CterDisposicionAsientos.Name = "CterDisposicionAsientos";
            this.CterDisposicionAsientos.Size = new System.Drawing.Size(586, 295);
            this.CterDisposicionAsientos.TabIndex = 5;
            this.CterDisposicionAsientos.Text = "guna2ContainerControl1";
            // 
            // PctbxSalida
            // 
            this.PctbxSalida.BackColor = System.Drawing.Color.Transparent;
            this.PctbxSalida.FillColor = System.Drawing.Color.Red;
            this.PctbxSalida.Image = ((System.Drawing.Image)(resources.GetObject("PctbxSalida.Image")));
            this.PctbxSalida.ImageRotate = 0F;
            this.PctbxSalida.Location = new System.Drawing.Point(532, 7);
            this.PctbxSalida.Name = "PctbxSalida";
            this.PctbxSalida.Size = new System.Drawing.Size(40, 39);
            this.PctbxSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctbxSalida.TabIndex = 8;
            this.PctbxSalida.TabStop = false;
            this.PctbxSalida.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 39);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // TbxPantalla
            // 
            this.TbxPantalla.BackColor = System.Drawing.Color.Black;
            this.TbxPantalla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxPantalla.DefaultText = "PANTALLA";
            this.TbxPantalla.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxPantalla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxPantalla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPantalla.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPantalla.FillColor = System.Drawing.Color.Black;
            this.TbxPantalla.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPantalla.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPantalla.ForeColor = System.Drawing.Color.White;
            this.TbxPantalla.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPantalla.Location = new System.Drawing.Point(145, 7);
            this.TbxPantalla.Margin = new System.Windows.Forms.Padding(7);
            this.TbxPantalla.Name = "TbxPantalla";
            this.TbxPantalla.PasswordChar = '\0';
            this.TbxPantalla.PlaceholderText = "";
            this.TbxPantalla.SelectedText = "";
            this.TbxPantalla.Size = new System.Drawing.Size(301, 39);
            this.TbxPantalla.TabIndex = 6;
            this.TbxPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbxCapacidad
            // 
            this.CbxCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.CbxCapacidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxCapacidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxCapacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCapacidad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxCapacidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxCapacidad.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxCapacidad.ItemHeight = 30;
            this.CbxCapacidad.Items.AddRange(new object[] {
            "5",
            "14",
            "19",
            "27",
            "32"});
            this.CbxCapacidad.Location = new System.Drawing.Point(197, 52);
            this.CbxCapacidad.Name = "CbxCapacidad";
            this.CbxCapacidad.Size = new System.Drawing.Size(95, 36);
            this.CbxCapacidad.TabIndex = 6;
            this.CbxCapacidad.SelectedIndexChanged += new System.EventHandler(this.CbxCapacidad_SelectedIndexChanged);
            // 
            // UC_Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CbxCapacidad);
            this.Controls.Add(this.CterDisposicionAsientos);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnCrearSala);
            this.Name = "UC_Salas";
            this.Size = new System.Drawing.Size(629, 447);
            this.CterDisposicionAsientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctbxSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnCrearSala;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbxNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ContainerControl CterDisposicionAsientos;
        private Guna.UI2.WinForms.Guna2TextBox TbxPantalla;
        private Guna.UI2.WinForms.Guna2PictureBox PctbxSalida;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CbxCapacidad;
    }
}
