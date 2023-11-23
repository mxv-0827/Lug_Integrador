namespace UI
{
    partial class Frm_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registro));
            this.uC_DatosPersonales1 = new UI.FRM_CLIENTE.UC_DatosPersonales();
            this.uC_Membresias1 = new UI.FRM_CLIENTE.UC_Membresias();
            this.SuspendLayout();
            // 
            // uC_DatosPersonales1
            // 
            this.uC_DatosPersonales1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_DatosPersonales1.BackgroundImage")));
            this.uC_DatosPersonales1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_DatosPersonales1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DatosPersonales1.Location = new System.Drawing.Point(0, 0);
            this.uC_DatosPersonales1.Name = "uC_DatosPersonales1";
            this.uC_DatosPersonales1.Size = new System.Drawing.Size(613, 450);
            this.uC_DatosPersonales1.TabIndex = 0;
            // 
            // uC_Membresias1
            // 
            this.uC_Membresias1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Membresias1.Location = new System.Drawing.Point(0, 0);
            this.uC_Membresias1.Name = "uC_Membresias1";
            this.uC_Membresias1.Size = new System.Drawing.Size(613, 450);
            this.uC_Membresias1.TabIndex = 1;
            // 
            // Frm_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.uC_Membresias1);
            this.Controls.Add(this.uC_DatosPersonales1);
            this.Name = "Frm_Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Frm_Registro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FRM_CLIENTE.UC_DatosPersonales uC_DatosPersonales1;
        private FRM_CLIENTE.UC_Membresias uC_Membresias1;
    }
}