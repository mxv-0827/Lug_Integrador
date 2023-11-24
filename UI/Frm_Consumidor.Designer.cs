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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_Home1 = new UI.FRM_CLIENTE.UC_Home();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnHome);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(154, 450);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.Controls.Add(this.uC_Home1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(154, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(566, 450);
            this.guna2Panel2.TabIndex = 1;
            // 
            // uC_Home1
            // 
            this.uC_Home1.AutoScroll = true;
            this.uC_Home1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(566, 450);
            this.uC_Home1.TabIndex = 0;
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
            // Frm_Consumidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Frm_Consumidor";
            this.Text = "Frm_Consumidor";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private FRM_CLIENTE.UC_Home uC_Home1;
        private Guna.UI2.WinForms.Guna2Button BtnHome;
    }
}