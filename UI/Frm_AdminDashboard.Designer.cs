namespace UI
{
    partial class Frm_AdminDashboard
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
            this.BtnPeliculas = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCombos = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSalas = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCupones = new Guna.UI2.WinForms.Guna2Button();
            this.lblBienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PnlMainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_Combos1 = new UI.FRM_ADMIN.UC_Combos();
            this.uC_Salas1 = new UI.FRM_ADMIN.UC_Salas();
            this.uC_Cupones1 = new UI.FRM_ADMIN.UC_Cupones();
            this.uC_Peliculas1 = new UI.FRM_ADMIN.UC_Peliculas();
            this.guna2Panel1.SuspendLayout();
            this.PnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.BtnPeliculas);
            this.guna2Panel1.Controls.Add(this.BtnCombos);
            this.guna2Panel1.Controls.Add(this.BtnSalas);
            this.guna2Panel1.Controls.Add(this.BtnCupones);
            this.guna2Panel1.Controls.Add(this.lblBienvenida);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 488);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BtnPeliculas
            // 
            this.BtnPeliculas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPeliculas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPeliculas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPeliculas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPeliculas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPeliculas.ForeColor = System.Drawing.Color.White;
            this.BtnPeliculas.Location = new System.Drawing.Point(0, 217);
            this.BtnPeliculas.Name = "BtnPeliculas";
            this.BtnPeliculas.Size = new System.Drawing.Size(200, 45);
            this.BtnPeliculas.TabIndex = 3;
            this.BtnPeliculas.Text = "ABM Peliculas";
            this.BtnPeliculas.Click += new System.EventHandler(this.BtnPeliculas_Click);
            // 
            // BtnCombos
            // 
            this.BtnCombos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCombos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCombos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCombos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCombos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCombos.ForeColor = System.Drawing.Color.White;
            this.BtnCombos.Location = new System.Drawing.Point(0, 267);
            this.BtnCombos.Name = "BtnCombos";
            this.BtnCombos.Size = new System.Drawing.Size(200, 45);
            this.BtnCombos.TabIndex = 2;
            this.BtnCombos.Text = "ABM Combos";
            this.BtnCombos.Click += new System.EventHandler(this.BtnCombos_Click);
            // 
            // BtnSalas
            // 
            this.BtnSalas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSalas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSalas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSalas.ForeColor = System.Drawing.Color.White;
            this.BtnSalas.Location = new System.Drawing.Point(0, 166);
            this.BtnSalas.Name = "BtnSalas";
            this.BtnSalas.Size = new System.Drawing.Size(200, 45);
            this.BtnSalas.TabIndex = 2;
            this.BtnSalas.Text = "ABM Salas";
            this.BtnSalas.Click += new System.EventHandler(this.BtnSalas_Click);
            // 
            // BtnCupones
            // 
            this.BtnCupones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCupones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCupones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCupones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCupones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCupones.ForeColor = System.Drawing.Color.White;
            this.BtnCupones.Location = new System.Drawing.Point(0, 318);
            this.BtnCupones.Name = "BtnCupones";
            this.BtnCupones.Size = new System.Drawing.Size(200, 45);
            this.BtnCupones.TabIndex = 0;
            this.BtnCupones.Text = "ABM Cupones";
            this.BtnCupones.Click += new System.EventHandler(this.BtnCupones_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Location = new System.Drawing.Point(12, 76);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(59, 15);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido: ";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(200, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(629, 41);
            this.guna2Panel2.TabIndex = 1;
            // 
            // PnlMainContainer
            // 
            this.PnlMainContainer.Controls.Add(this.uC_Peliculas1);
            this.PnlMainContainer.Controls.Add(this.uC_Combos1);
            this.PnlMainContainer.Controls.Add(this.uC_Salas1);
            this.PnlMainContainer.Controls.Add(this.uC_Cupones1);
            this.PnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainContainer.Location = new System.Drawing.Point(200, 41);
            this.PnlMainContainer.Name = "PnlMainContainer";
            this.PnlMainContainer.Size = new System.Drawing.Size(629, 447);
            this.PnlMainContainer.TabIndex = 2;
            // 
            // uC_Combos1
            // 
            this.uC_Combos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Combos1.Location = new System.Drawing.Point(0, 0);
            this.uC_Combos1.Name = "uC_Combos1";
            this.uC_Combos1.Size = new System.Drawing.Size(629, 447);
            this.uC_Combos1.TabIndex = 2;
            // 
            // uC_Salas1
            // 
            this.uC_Salas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Salas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Salas1.Name = "uC_Salas1";
            this.uC_Salas1.Size = new System.Drawing.Size(629, 447);
            this.uC_Salas1.TabIndex = 1;
            // 
            // uC_Cupones1
            // 
            this.uC_Cupones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Cupones1.Location = new System.Drawing.Point(0, 0);
            this.uC_Cupones1.Name = "uC_Cupones1";
            this.uC_Cupones1.Size = new System.Drawing.Size(629, 447);
            this.uC_Cupones1.TabIndex = 0;
            // 
            // uC_Peliculas1
            // 
            this.uC_Peliculas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Peliculas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Peliculas1.Name = "uC_Peliculas1";
            this.uC_Peliculas1.Size = new System.Drawing.Size(629, 447);
            this.uC_Peliculas1.TabIndex = 3;
            // 
            // Frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 488);
            this.Controls.Add(this.PnlMainContainer);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Frm_AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.Frm_AdminDashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.PnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBienvenida;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel PnlMainContainer;
        private Guna.UI2.WinForms.Guna2Button BtnCupones;
        private Guna.UI2.WinForms.Guna2Button BtnSalas;
        private FRM_ADMIN.UC_Cupones uC_Cupones1;
        private FRM_ADMIN.UC_Salas uC_Salas1;
        private Guna.UI2.WinForms.Guna2Button BtnCombos;
        private FRM_ADMIN.UC_Combos uC_Combos1;
        private Guna.UI2.WinForms.Guna2Button BtnPeliculas;
        private FRM_ADMIN.UC_Peliculas uC_Peliculas1;
    }
}