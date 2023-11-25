namespace UI
{
    partial class Frm_Compra
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
            this.uC_Pelicula1 = new UI.FRM_CLIENTE.UC_Pelicula();
            this.uC_HorarioPelicula1 = new UI.FRM_CLIENTE.UC_HorarioPelicula();
            this.SuspendLayout();
            // 
            // uC_Pelicula1
            // 
            this.uC_Pelicula1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Pelicula1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Pelicula1.Location = new System.Drawing.Point(0, 0);
            this.uC_Pelicula1.Name = "uC_Pelicula1";
            this.uC_Pelicula1.Pelicula = null;
            this.uC_Pelicula1.Size = new System.Drawing.Size(1030, 525);
            this.uC_Pelicula1.TabIndex = 0;
            // 
            // uC_HorarioPelicula1
            // 
            this.uC_HorarioPelicula1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_HorarioPelicula1.Location = new System.Drawing.Point(0, 0);
            this.uC_HorarioPelicula1.Name = "uC_HorarioPelicula1";
            this.uC_HorarioPelicula1.Size = new System.Drawing.Size(1030, 525);
            this.uC_HorarioPelicula1.TabIndex = 1;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 525);
            this.Controls.Add(this.uC_HorarioPelicula1);
            this.Controls.Add(this.uC_Pelicula1);
            this.Name = "Frm_Compra";
            this.Text = "Frm_Compra";
            this.Load += new System.EventHandler(this.Frm_Compra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FRM_CLIENTE.UC_Pelicula uC_Pelicula1;
        private FRM_CLIENTE.UC_HorarioPelicula uC_HorarioPelicula1;
    }
}