namespace UI.FRM_CLIENTE
{
    partial class UC_Catalogo
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
            this.CbxPeliculas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnReestablecer = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // CbxPeliculas
            // 
            this.CbxPeliculas.BackColor = System.Drawing.Color.Transparent;
            this.CbxPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxPeliculas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPeliculas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxPeliculas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxPeliculas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxPeliculas.ItemHeight = 30;
            this.CbxPeliculas.Items.AddRange(new object[] {
            "  "});
            this.CbxPeliculas.Location = new System.Drawing.Point(143, 66);
            this.CbxPeliculas.Name = "CbxPeliculas";
            this.CbxPeliculas.Size = new System.Drawing.Size(276, 36);
            this.CbxPeliculas.TabIndex = 0;
            this.CbxPeliculas.SelectedIndexChanged += new System.EventHandler(this.CbxPeliculas_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(153, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(256, 39);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Busca una pelicula!";
            // 
            // BtnReestablecer
            // 
            this.BtnReestablecer.BorderRadius = 3;
            this.BtnReestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReestablecer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReestablecer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReestablecer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReestablecer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReestablecer.FillColor = System.Drawing.Color.BlueViolet;
            this.BtnReestablecer.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReestablecer.ForeColor = System.Drawing.Color.White;
            this.BtnReestablecer.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.BtnReestablecer.Location = new System.Drawing.Point(441, 66);
            this.BtnReestablecer.Name = "BtnReestablecer";
            this.BtnReestablecer.Size = new System.Drawing.Size(105, 36);
            this.BtnReestablecer.TabIndex = 2;
            this.BtnReestablecer.Text = "Reestablecer";
            this.BtnReestablecer.Click += new System.EventHandler(this.BtnReestablecer_Click);
            // 
            // UC_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BtnReestablecer);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.CbxPeliculas);
            this.Name = "UC_Catalogo";
            this.Size = new System.Drawing.Size(566, 450);
            this.Enter += new System.EventHandler(this.UC_Catalogo_Enter);
            this.Leave += new System.EventHandler(this.UC_Catalogo_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox CbxPeliculas;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BtnReestablecer;
    }
}
