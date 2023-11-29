namespace UI
{
    partial class Frm_Consumidor
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.BtnConfig = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCompras = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCatalogo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_Catalogo1 = new UI.FRM_CLIENTE.UC_Catalogo();
            this.uC_Home1 = new UI.FRM_CLIENTE.UC_Home();
            this.uC_ComprasCliente1 = new UI.FRM_CLIENTE.UC_ComprasCliente();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnLogOut);
            this.guna2Panel1.Controls.Add(this.BtnConfig);
            this.guna2Panel1.Controls.Add(this.BtnCompras);
            this.guna2Panel1.Controls.Add(this.BtnCatalogo);
            this.guna2Panel1.Controls.Add(this.BtnHome);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(154, 450);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 407);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(154, 40);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Cerrar Sesion";
            // 
            // BtnConfig
            // 
            this.BtnConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnConfig.ForeColor = System.Drawing.Color.White;
            this.BtnConfig.Location = new System.Drawing.Point(0, 234);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(154, 40);
            this.BtnConfig.TabIndex = 4;
            this.BtnConfig.Text = "Configuracion";
            // 
            // BtnCompras
            // 
            this.BtnCompras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCompras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCompras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCompras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCompras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCompras.ForeColor = System.Drawing.Color.White;
            this.BtnCompras.Location = new System.Drawing.Point(0, 188);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Size = new System.Drawing.Size(154, 40);
            this.BtnCompras.TabIndex = 3;
            this.BtnCompras.Text = "Mis compras";
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCatalogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCatalogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCatalogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCatalogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCatalogo.ForeColor = System.Drawing.Color.White;
            this.BtnCatalogo.Location = new System.Drawing.Point(0, 142);
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(154, 40);
            this.BtnCatalogo.TabIndex = 2;
            this.BtnCatalogo.Text = "Catalogo";
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 96);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(154, 40);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.Controls.Add(this.uC_ComprasCliente1);
            this.guna2Panel2.Controls.Add(this.uC_Catalogo1);
            this.guna2Panel2.Controls.Add(this.uC_Home1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(154, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(572, 450);
            this.guna2Panel2.TabIndex = 1;
            // 
            // uC_Catalogo1
            // 
            this.uC_Catalogo1.AutoScroll = true;
            this.uC_Catalogo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Catalogo1.Cliente = null;
            this.uC_Catalogo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Catalogo1.Location = new System.Drawing.Point(0, 0);
            this.uC_Catalogo1.Name = "uC_Catalogo1";
            this.uC_Catalogo1.Size = new System.Drawing.Size(572, 450);
            this.uC_Catalogo1.TabIndex = 3;
            // 
            // uC_Home1
            // 
            this.uC_Home1.AutoScroll = true;
            this.uC_Home1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(572, 450);
            this.uC_Home1.TabIndex = 0;
            // 
            // uC_ComprasCliente1
            // 
            this.uC_ComprasCliente1.AutoScroll = true;
            this.uC_ComprasCliente1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_ComprasCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ComprasCliente1.Location = new System.Drawing.Point(0, 0);
            this.uC_ComprasCliente1.Name = "uC_ComprasCliente1";
            this.uC_ComprasCliente1.Size = new System.Drawing.Size(572, 450);
            this.uC_ComprasCliente1.TabIndex = 4;
            // 
            // Frm_Consumidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Frm_Consumidor";
            this.Text = "Frm_Consumidor";
            this.Load += new System.EventHandler(this.Frm_Consumidor_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button BtnHome;
        private Guna.UI2.WinForms.Guna2Button BtnCatalogo;
        private FRM_CLIENTE.UC_Home uC_Home1;
        private FRM_CLIENTE.UC_Catalogo uC_Catalogo1;
        private Guna.UI2.WinForms.Guna2Button BtnLogOut;
        private Guna.UI2.WinForms.Guna2Button BtnConfig;
        private Guna.UI2.WinForms.Guna2Button BtnCompras;
        private FRM_CLIENTE.UC_ComprasCliente uC_ComprasCliente1;
    }
}