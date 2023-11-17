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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCrearCodigo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnCrearCupon = new Guna.UI2.WinForms.Guna2Button();
            this.CbxIDDesc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DgvCupones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TbxCodigo = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.BtnCrearCodigo.FillColor = System.Drawing.Color.Red;
            this.BtnCrearCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearCodigo.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCodigo.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrearCodigo.Image")));
            this.BtnCrearCodigo.Location = new System.Drawing.Point(184, 47);
            this.BtnCrearCodigo.Name = "BtnCrearCodigo";
            this.BtnCrearCodigo.Size = new System.Drawing.Size(34, 36);
            this.BtnCrearCodigo.TabIndex = 0;
            this.BtnCrearCodigo.Click += new System.EventHandler(this.BtnCrearCodigo_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(63, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Codigo de cupon:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(247, 26);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Descuento (%):";
            // 
            // BtnCrearCupon
            // 
            this.BtnCrearCupon.BorderRadius = 3;
            this.BtnCrearCupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearCupon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCupon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearCupon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearCupon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearCupon.FillColor = System.Drawing.Color.Red;
            this.BtnCrearCupon.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCupon.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCupon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCrearCupon.Location = new System.Drawing.Point(422, 47);
            this.BtnCrearCupon.Name = "BtnCrearCupon";
            this.BtnCrearCupon.Size = new System.Drawing.Size(104, 36);
            this.BtnCrearCupon.TabIndex = 5;
            this.BtnCrearCupon.Text = "Crear cupon";
            this.BtnCrearCupon.Click += new System.EventHandler(this.BtnCrearCupon_Click);
            // 
            // CbxIDDesc
            // 
            this.CbxIDDesc.BackColor = System.Drawing.Color.Transparent;
            this.CbxIDDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxIDDesc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxIDDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxIDDesc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxIDDesc.ForeColor = System.Drawing.Color.Black;
            this.CbxIDDesc.ItemHeight = 30;
            this.CbxIDDesc.Location = new System.Drawing.Point(247, 47);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DgvCupones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCupones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCupones.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCupones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCupones.ColumnHeadersHeight = 30;
            this.DgvCupones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCupones.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCupones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCupones.Location = new System.Drawing.Point(39, 131);
            this.DgvCupones.Name = "DgvCupones";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCupones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvCupones.RowHeadersVisible = false;
            this.DgvCupones.RowTemplate.DividerHeight = 5;
            this.DgvCupones.RowTemplate.Height = 40;
            this.DgvCupones.Size = new System.Drawing.Size(535, 302);
            this.DgvCupones.TabIndex = 10;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.DarkGray;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCupones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCupones.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.DgvCupones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCupones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.DgvCupones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCupones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCupones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCupones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCupones.ThemeStyle.HeaderStyle.Height = 30;
            this.DgvCupones.ThemeStyle.ReadOnly = false;
            this.DgvCupones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.DgvCupones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCupones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCupones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCupones.ThemeStyle.RowsStyle.Height = 40;
            this.DgvCupones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.DgvCupones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCupones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCupones_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 152.2843F;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 79.38476F;
            this.Column2.HeaderText = "Descuento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 68.33096F;
            this.Column3.HeaderText = "Habilitado";
            this.Column3.Name = "Column3";
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.BackColor = System.Drawing.Color.Transparent;
            this.TbxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxCodigo.DefaultText = "";
            this.TbxCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCodigo.ForeColor = System.Drawing.Color.Black;
            this.TbxCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxCodigo.Location = new System.Drawing.Point(63, 47);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.PasswordChar = '\0';
            this.TbxCodigo.PlaceholderText = "";
            this.TbxCodigo.ReadOnly = true;
            this.TbxCodigo.SelectedText = "";
            this.TbxCodigo.Size = new System.Drawing.Size(115, 36);
            this.TbxCodigo.TabIndex = 2;
            this.TbxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_Cupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.DgvCupones);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.CbxIDDesc);
            this.Controls.Add(this.BtnCrearCodigo);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnCrearCupon);
            this.Name = "UC_Cupones";
            this.Size = new System.Drawing.Size(629, 498);
            this.Load += new System.EventHandler(this.UC_Cupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCupones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnCrearCodigo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button BtnCrearCupon;
        private Guna.UI2.WinForms.Guna2ComboBox CbxIDDesc;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCupones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2TextBox TbxCodigo;
    }
}
