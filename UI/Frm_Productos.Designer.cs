namespace UI
{
    partial class Frm_Productos
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
            this.CbxTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxDimension = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxMembresia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnAgregarCarrito = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // CbxTipo
            // 
            this.CbxTipo.BackColor = System.Drawing.Color.Transparent;
            this.CbxTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxTipo.ItemHeight = 30;
            this.CbxTipo.Items.AddRange(new object[] {
            "Todos",
            "Combo",
            "Producto"});
            this.CbxTipo.Location = new System.Drawing.Point(25, 44);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(122, 36);
            this.CbxTipo.StartIndex = 0;
            this.CbxTipo.TabIndex = 12;
            this.CbxTipo.SelectedIndexChanged += new System.EventHandler(this.CbxTIpo_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(35, 17);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Tipo:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(153, 23);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(72, 17);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Dimension:";
            // 
            // CbxDimension
            // 
            this.CbxDimension.BackColor = System.Drawing.Color.Transparent;
            this.CbxDimension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxDimension.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDimension.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxDimension.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxDimension.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxDimension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxDimension.ItemHeight = 30;
            this.CbxDimension.Items.AddRange(new object[] {
            "Todos",
            "Chico",
            "Mediano",
            "Grande"});
            this.CbxDimension.Location = new System.Drawing.Point(153, 44);
            this.CbxDimension.Name = "CbxDimension";
            this.CbxDimension.Size = new System.Drawing.Size(122, 36);
            this.CbxDimension.StartIndex = 0;
            this.CbxDimension.TabIndex = 14;
            this.CbxDimension.SelectedIndexChanged += new System.EventHandler(this.CbxDimension_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(281, 23);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(74, 17);
            this.guna2HtmlLabel3.TabIndex = 24;
            this.guna2HtmlLabel3.Text = "Membresia:";
            // 
            // CbxMembresia
            // 
            this.CbxMembresia.BackColor = System.Drawing.Color.Transparent;
            this.CbxMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxMembresia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMembresia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxMembresia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxMembresia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMembresia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxMembresia.ItemHeight = 30;
            this.CbxMembresia.Location = new System.Drawing.Point(281, 44);
            this.CbxMembresia.Name = "CbxMembresia";
            this.CbxMembresia.Size = new System.Drawing.Size(122, 36);
            this.CbxMembresia.TabIndex = 23;
            this.CbxMembresia.SelectedIndexChanged += new System.EventHandler(this.CbxMembresia_SelectedIndexChanged);
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.BorderRadius = 3;
            this.BtnAgregarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarCarrito.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarCarrito.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregarCarrito.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAgregarCarrito.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAgregarCarrito.FillColor = System.Drawing.Color.Green;
            this.BtnAgregarCarrito.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarCarrito.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(433, 44);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(111, 36);
            this.BtnAgregarCarrito.TabIndex = 25;
            this.BtnAgregarCarrito.Text = "Agregar al carrito";
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.BtnAgregarCarrito_Click);
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.BtnAgregarCarrito);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.CbxMembresia);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.CbxDimension);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.CbxTipo);
            this.Name = "Frm_Productos";
            this.Text = "Frm_Productos";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox CbxTipo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CbxDimension;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox CbxMembresia;
        private Guna.UI2.WinForms.Guna2Button BtnAgregarCarrito;
    }
}