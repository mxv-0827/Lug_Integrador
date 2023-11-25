namespace UI.FRM_CLIENTE
{
    partial class UC_Pelicula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PctbxPelicula = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvHorariosPelicula = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LblDuracion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PctbxPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorariosPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // PctbxPelicula
            // 
            this.PctbxPelicula.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PctbxPelicula.ImageRotate = 0F;
            this.PctbxPelicula.Location = new System.Drawing.Point(23, 67);
            this.PctbxPelicula.Name = "PctbxPelicula";
            this.PctbxPelicula.Size = new System.Drawing.Size(248, 439);
            this.PctbxPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctbxPelicula.TabIndex = 0;
            this.PctbxPelicula.TabStop = false;
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(309, 22);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(267, 39);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Avengers: Endgame";
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.BorderThickness = 0;
            this.TbxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxDescripcion.DefaultText = "";
            this.TbxDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDescripcion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TbxDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TbxDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDescripcion.Location = new System.Drawing.Point(309, 67);
            this.TbxDescripcion.Multiline = true;
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.PasswordChar = '\0';
            this.TbxDescripcion.PlaceholderText = "";
            this.TbxDescripcion.ReadOnly = true;
            this.TbxDescripcion.SelectedText = "";
            this.TbxDescripcion.Size = new System.Drawing.Size(565, 154);
            this.TbxDescripcion.TabIndex = 2;
            // 
            // DgvHorariosPelicula
            // 
            this.DgvHorariosPelicula.AllowUserToAddRows = false;
            this.DgvHorariosPelicula.AllowUserToDeleteRows = false;
            this.DgvHorariosPelicula.AllowUserToResizeColumns = false;
            this.DgvHorariosPelicula.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvHorariosPelicula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHorariosPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHorariosPelicula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHorariosPelicula.ColumnHeadersHeight = 40;
            this.DgvHorariosPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHorariosPelicula.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHorariosPelicula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvHorariosPelicula.Location = new System.Drawing.Point(378, 264);
            this.DgvHorariosPelicula.Name = "DgvHorariosPelicula";
            this.DgvHorariosPelicula.ReadOnly = true;
            this.DgvHorariosPelicula.RowHeadersVisible = false;
            this.DgvHorariosPelicula.RowTemplate.DividerHeight = 10;
            this.DgvHorariosPelicula.RowTemplate.Height = 45;
            this.DgvHorariosPelicula.Size = new System.Drawing.Size(496, 242);
            this.DgvHorariosPelicula.TabIndex = 8;
            this.DgvHorariosPelicula.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvHorariosPelicula.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvHorariosPelicula.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvHorariosPelicula.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvHorariosPelicula.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvHorariosPelicula.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvHorariosPelicula.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvHorariosPelicula.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvHorariosPelicula.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvHorariosPelicula.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvHorariosPelicula.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvHorariosPelicula.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvHorariosPelicula.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvHorariosPelicula.ThemeStyle.ReadOnly = true;
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.Height = 45;
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvHorariosPelicula.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvHorariosPelicula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHorariosPelicula_CellClick);
            this.DgvHorariosPelicula.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHorariosPelicula_CellMouseEnter);
            this.DgvHorariosPelicula.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHorariosPelicula_CellMouseLeave);
            // 
            // LblDuracion
            // 
            this.LblDuracion.BackColor = System.Drawing.Color.Transparent;
            this.LblDuracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracion.Location = new System.Drawing.Point(429, 227);
            this.LblDuracion.Name = "LblDuracion";
            this.LblDuracion.Size = new System.Drawing.Size(59, 19);
            this.LblDuracion.TabIndex = 9;
            this.LblDuracion.Text = "Duracion";
            // 
            // LblFecha
            // 
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(309, 227);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(38, 19);
            this.LblFecha.TabIndex = 10;
            this.LblFecha.Text = "Fecha";
            // 
            // UC_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblDuracion);
            this.Controls.Add(this.DgvHorariosPelicula);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.PctbxPelicula);
            this.Name = "UC_Pelicula";
            this.Size = new System.Drawing.Size(1046, 540);
            this.Enter += new System.EventHandler(this.UC_Pelicula_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.PctbxPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorariosPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PctbxPelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblNombre;
        private Guna.UI2.WinForms.Guna2TextBox TbxDescripcion;
        private Guna.UI2.WinForms.Guna2DataGridView DgvHorariosPelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDuracion;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFecha;
    }
}
