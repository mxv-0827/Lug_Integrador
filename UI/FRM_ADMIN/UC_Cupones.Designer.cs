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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cupones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCrearCodigo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnCrearCupon = new Guna.UI2.WinForms.Guna2Button();
            this.CbxIDDesc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DgvCupones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCupones)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrearCodigo
            // 
            this.BtnCrearCodigo.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCrearCodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearCodigo.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCodigo.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrearCodigo.Image")));
            this.BtnCrearCodigo.Location = new System.Drawing.Point(228, 21);
            this.BtnCrearCodigo.Name = "BtnCrearCodigo";
            this.BtnCrearCodigo.Size = new System.Drawing.Size(34, 35);
            this.BtnCrearCodigo.TabIndex = 0;
            this.BtnCrearCodigo.Click += new System.EventHandler(this.BtnCrearCodigo_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 42);
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
            this.TbxCodigo.Location = new System.Drawing.Point(107, 21);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.PasswordChar = '\0';
            this.TbxCodigo.PlaceholderText = "";
            this.TbxCodigo.ReadOnly = true;
            this.TbxCodigo.SelectedText = "";
            this.TbxCodigo.Size = new System.Drawing.Size(115, 36);
            this.TbxCodigo.TabIndex = 2;
            this.TbxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(282, 42);
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
            this.BtnCrearCupon.Location = new System.Drawing.Point(510, 21);
            this.BtnCrearCupon.Name = "BtnCrearCupon";
            this.BtnCrearCupon.Size = new System.Drawing.Size(94, 36);
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
            this.CbxIDDesc.Location = new System.Drawing.Point(363, 21);
            this.CbxIDDesc.Name = "CbxIDDesc";
            this.CbxIDDesc.Size = new System.Drawing.Size(115, 36);
            this.CbxIDDesc.TabIndex = 6;
            // 
            // DgvCupones
            // 
            this.DgvCupones.AllowUserToAddRows = false;
            this.DgvCupones.AllowUserToDeleteRows = false;
            this.DgvCupones.AllowUserToResizeColumns = false;
            this.DgvCupones.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DgvCupones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCupones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvCupones.ColumnHeadersHeight = 30;
            this.DgvCupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvCupones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCupones.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvCupones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DgvCupones.Location = new System.Drawing.Point(90, 108);
            this.DgvCupones.Name = "DgvCupones";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCupones.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvCupones.RowHeadersVisible = false;
            this.DgvCupones.RowTemplate.DividerHeight = 5;
            this.DgvCupones.RowTemplate.Height = 40;
            this.DgvCupones.Size = new System.Drawing.Size(440, 263);
            this.DgvCupones.TabIndex = 10;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCupones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCupones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DgvCupones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DgvCupones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCupones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCupones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.DgvCupones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvCupones.ThemeStyle.HeaderStyle.Height = 30;
            this.DgvCupones.ThemeStyle.ReadOnly = false;
            this.DgvCupones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCupones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCupones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCupones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCupones.ThemeStyle.RowsStyle.Height = 40;
            this.DgvCupones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DgvCupones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCupones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCupones_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 152.2843F;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 79.38476F;
            this.Column2.HeaderText = "Descuento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 165;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 68.33096F;
            this.Column3.HeaderText = "Habilitado";
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // UC_Cupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvCupones);
            this.Controls.Add(this.CbxIDDesc);
            this.Controls.Add(this.BtnCrearCupon);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnCrearCodigo);
            this.Name = "UC_Cupones";
            this.Size = new System.Drawing.Size(629, 447);
            this.Load += new System.EventHandler(this.UC_Cupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCupones)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView DgvCupones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}
