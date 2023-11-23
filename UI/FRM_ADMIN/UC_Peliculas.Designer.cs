namespace UI.FRM_ADMIN
{
    partial class UC_Peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Peliculas));
            this.BtnCrearPelicula = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxDuracion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxEstreno = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxRutaPortada = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxRestriccionEdad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbxGeneros = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxPelicula = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxSala = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnAsignar = new Guna.UI2.WinForms.Guna2Button();
            this.CterGeneros = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.CterHorariosPelicula = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.OfdImagenPeli = new System.Windows.Forms.OpenFileDialog();
            this.PctbxImagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnElegirImagen = new Guna.UI2.WinForms.Guna2Button();
            this.BtnElegirTrailer = new Guna.UI2.WinForms.Guna2Button();
            this.TbxRutaTrailer = new Guna.UI2.WinForms.Guna2TextBox();
            this.OfdTrailer = new System.Windows.Forms.OpenFileDialog();
            this.WmpTrailer = new AxWMPLib.AxWindowsMediaPlayer();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.PctbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpTrailer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrearPelicula
            // 
            this.BtnCrearPelicula.BorderRadius = 3;
            this.BtnCrearPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearPelicula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearPelicula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearPelicula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearPelicula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearPelicula.FillColor = System.Drawing.Color.Red;
            this.BtnCrearPelicula.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearPelicula.ForeColor = System.Drawing.Color.White;
            this.BtnCrearPelicula.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCrearPelicula.Location = new System.Drawing.Point(596, 549);
            this.BtnCrearPelicula.Name = "BtnCrearPelicula";
            this.BtnCrearPelicula.Size = new System.Drawing.Size(104, 35);
            this.BtnCrearPelicula.TabIndex = 0;
            this.BtnCrearPelicula.Text = "Crear pelicula";
            this.BtnCrearPelicula.Click += new System.EventHandler(this.BtnCrearPelicula_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(29, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(56, 17);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Nombre:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxNombre.DefaultText = "";
            this.TbxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxNombre.Location = new System.Drawing.Point(29, 56);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.PasswordChar = '\0';
            this.TbxNombre.PlaceholderText = "";
            this.TbxNombre.SelectedText = "";
            this.TbxNombre.Size = new System.Drawing.Size(164, 36);
            this.TbxNombre.TabIndex = 2;
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.AutoScroll = true;
            this.TbxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxDescripcion.DefaultText = "";
            this.TbxDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDescripcion.Location = new System.Drawing.Point(277, 56);
            this.TbxDescripcion.Multiline = true;
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.PasswordChar = '\0';
            this.TbxDescripcion.PlaceholderText = "";
            this.TbxDescripcion.SelectedText = "";
            this.TbxDescripcion.Size = new System.Drawing.Size(313, 146);
            this.TbxDescripcion.TabIndex = 6;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(277, 35);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(78, 17);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Descripcion:";
            // 
            // TbxDuracion
            // 
            this.TbxDuracion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxDuracion.DefaultText = "";
            this.TbxDuracion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxDuracion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxDuracion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDuracion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDuracion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDuracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxDuracion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDuracion.Location = new System.Drawing.Point(29, 203);
            this.TbxDuracion.Name = "TbxDuracion";
            this.TbxDuracion.PasswordChar = '\0';
            this.TbxDuracion.PlaceholderText = "Minutos";
            this.TbxDuracion.SelectedText = "";
            this.TbxDuracion.Size = new System.Drawing.Size(164, 36);
            this.TbxDuracion.TabIndex = 10;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(29, 182);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(62, 17);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Duracion:";
            // 
            // TbxEstreno
            // 
            this.TbxEstreno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxEstreno.DefaultText = "";
            this.TbxEstreno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxEstreno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxEstreno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEstreno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxEstreno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxEstreno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxEstreno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxEstreno.Location = new System.Drawing.Point(29, 129);
            this.TbxEstreno.Name = "TbxEstreno";
            this.TbxEstreno.PasswordChar = '\0';
            this.TbxEstreno.PlaceholderText = "dd/mm/YYYY";
            this.TbxEstreno.SelectedText = "";
            this.TbxEstreno.Size = new System.Drawing.Size(164, 36);
            this.TbxEstreno.TabIndex = 8;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(29, 108);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(53, 17);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "Estreno:";
            // 
            // TbxRutaPortada
            // 
            this.TbxRutaPortada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxRutaPortada.DefaultText = "";
            this.TbxRutaPortada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxRutaPortada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxRutaPortada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxRutaPortada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxRutaPortada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxRutaPortada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxRutaPortada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxRutaPortada.Location = new System.Drawing.Point(29, 354);
            this.TbxRutaPortada.Name = "TbxRutaPortada";
            this.TbxRutaPortada.PasswordChar = '\0';
            this.TbxRutaPortada.PlaceholderText = "";
            this.TbxRutaPortada.ReadOnly = true;
            this.TbxRutaPortada.SelectedText = "";
            this.TbxRutaPortada.Size = new System.Drawing.Size(164, 36);
            this.TbxRutaPortada.TabIndex = 12;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(29, 261);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(125, 17);
            this.guna2HtmlLabel8.TabIndex = 15;
            this.guna2HtmlLabel8.Text = "Restriccion de edad:";
            // 
            // CbxRestriccionEdad
            // 
            this.CbxRestriccionEdad.BackColor = System.Drawing.Color.Transparent;
            this.CbxRestriccionEdad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxRestriccionEdad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxRestriccionEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRestriccionEdad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxRestriccionEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxRestriccionEdad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxRestriccionEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxRestriccionEdad.ItemHeight = 30;
            this.CbxRestriccionEdad.Items.AddRange(new object[] {
            "1"});
            this.CbxRestriccionEdad.Location = new System.Drawing.Point(29, 282);
            this.CbxRestriccionEdad.Name = "CbxRestriccionEdad";
            this.CbxRestriccionEdad.Size = new System.Drawing.Size(164, 36);
            this.CbxRestriccionEdad.TabIndex = 16;
            // 
            // CbxGeneros
            // 
            this.CbxGeneros.BackColor = System.Drawing.Color.Transparent;
            this.CbxGeneros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxGeneros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGeneros.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxGeneros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxGeneros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxGeneros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxGeneros.ItemHeight = 30;
            this.CbxGeneros.Location = new System.Drawing.Point(277, 245);
            this.CbxGeneros.Name = "CbxGeneros";
            this.CbxGeneros.Size = new System.Drawing.Size(164, 36);
            this.CbxGeneros.TabIndex = 18;
            this.CbxGeneros.SelectedIndexChanged += new System.EventHandler(this.CbxGeneros_SelectedIndexChanged);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(277, 224);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(63, 17);
            this.guna2HtmlLabel9.TabIndex = 17;
            this.guna2HtmlLabel9.Text = "Genero/s:";
            // 
            // CbxPelicula
            // 
            this.CbxPelicula.BackColor = System.Drawing.Color.Transparent;
            this.CbxPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxPelicula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPelicula.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxPelicula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxPelicula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxPelicula.ItemHeight = 30;
            this.CbxPelicula.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CbxPelicula.Location = new System.Drawing.Point(1004, 56);
            this.CbxPelicula.Name = "CbxPelicula";
            this.CbxPelicula.Size = new System.Drawing.Size(200, 36);
            this.CbxPelicula.TabIndex = 39;
            this.CbxPelicula.SelectedIndexChanged += new System.EventHandler(this.CbxPelicula_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1004, 37);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 17);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "Pelicula:";
            // 
            // CbxSala
            // 
            this.CbxSala.BackColor = System.Drawing.Color.Transparent;
            this.CbxSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxSala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSala.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxSala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxSala.ItemHeight = 30;
            this.CbxSala.Items.AddRange(new object[] {
            "1"});
            this.CbxSala.Location = new System.Drawing.Point(787, 56);
            this.CbxSala.Name = "CbxSala";
            this.CbxSala.Size = new System.Drawing.Size(200, 36);
            this.CbxSala.TabIndex = 37;
            this.CbxSala.SelectedIndexChanged += new System.EventHandler(this.CbxSala_SelectedIndexChanged);
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(787, 36);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(32, 17);
            this.guna2HtmlLabel11.TabIndex = 36;
            this.guna2HtmlLabel11.Text = "Sala:";
            // 
            // TbxFecha
            // 
            this.TbxFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxFecha.DefaultText = "";
            this.TbxFecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxFecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxFecha.Location = new System.Drawing.Point(787, 140);
            this.TbxFecha.Name = "TbxFecha";
            this.TbxFecha.PasswordChar = '\0';
            this.TbxFecha.PlaceholderText = "dd/mm/YYYY";
            this.TbxFecha.SelectedText = "";
            this.TbxFecha.Size = new System.Drawing.Size(200, 36);
            this.TbxFecha.TabIndex = 27;
            this.TbxFecha.TextChanged += new System.EventHandler(this.TbxFecha_TextChanged);
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(787, 119);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(40, 17);
            this.guna2HtmlLabel16.TabIndex = 26;
            this.guna2HtmlLabel16.Text = "Fecha:";
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.BorderRadius = 3;
            this.BtnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAsignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAsignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAsignar.FillColor = System.Drawing.Color.Red;
            this.BtnAsignar.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignar.ForeColor = System.Drawing.Color.White;
            this.BtnAsignar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAsignar.Location = new System.Drawing.Point(1004, 140);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(114, 36);
            this.BtnAsignar.TabIndex = 21;
            this.BtnAsignar.Text = "Asignar pelicula";
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // CterGeneros
            // 
            this.CterGeneros.AutoScroll = true;
            this.CterGeneros.Location = new System.Drawing.Point(277, 299);
            this.CterGeneros.Name = "CterGeneros";
            this.CterGeneros.Size = new System.Drawing.Size(313, 91);
            this.CterGeneros.TabIndex = 42;
            this.CterGeneros.Text = "guna2ContainerControl1";
            // 
            // CterHorariosPelicula
            // 
            this.CterHorariosPelicula.AutoScroll = true;
            this.CterHorariosPelicula.Location = new System.Drawing.Point(768, 232);
            this.CterHorariosPelicula.Name = "CterHorariosPelicula";
            this.CterHorariosPelicula.Size = new System.Drawing.Size(548, 183);
            this.CterHorariosPelicula.TabIndex = 43;
            this.CterHorariosPelicula.Text = "guna2ContainerControl1";
            // 
            // OfdImagenPeli
            // 
            this.OfdImagenPeli.FileName = "openFileDialog1";
            // 
            // PctbxImagen
            // 
            this.PctbxImagen.ImageRotate = 0F;
            this.PctbxImagen.Location = new System.Drawing.Point(29, 409);
            this.PctbxImagen.Name = "PctbxImagen";
            this.PctbxImagen.Size = new System.Drawing.Size(214, 175);
            this.PctbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctbxImagen.TabIndex = 44;
            this.PctbxImagen.TabStop = false;
            // 
            // BtnElegirImagen
            // 
            this.BtnElegirImagen.BorderRadius = 3;
            this.BtnElegirImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnElegirImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnElegirImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnElegirImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElegirImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnElegirImagen.FillColor = System.Drawing.Color.Red;
            this.BtnElegirImagen.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElegirImagen.ForeColor = System.Drawing.Color.White;
            this.BtnElegirImagen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnElegirImagen.Location = new System.Drawing.Point(199, 354);
            this.BtnElegirImagen.Name = "BtnElegirImagen";
            this.BtnElegirImagen.Size = new System.Drawing.Size(44, 35);
            this.BtnElegirImagen.TabIndex = 45;
            this.BtnElegirImagen.Text = "...";
            this.BtnElegirImagen.Click += new System.EventHandler(this.BtnElegirImagen_Click);
            // 
            // BtnElegirTrailer
            // 
            this.BtnElegirTrailer.BorderRadius = 3;
            this.BtnElegirTrailer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnElegirTrailer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnElegirTrailer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnElegirTrailer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElegirTrailer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnElegirTrailer.FillColor = System.Drawing.Color.Red;
            this.BtnElegirTrailer.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElegirTrailer.ForeColor = System.Drawing.Color.White;
            this.BtnElegirTrailer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnElegirTrailer.Location = new System.Drawing.Point(483, 421);
            this.BtnElegirTrailer.Name = "BtnElegirTrailer";
            this.BtnElegirTrailer.Size = new System.Drawing.Size(44, 36);
            this.BtnElegirTrailer.TabIndex = 47;
            this.BtnElegirTrailer.Text = "...";
            this.BtnElegirTrailer.Click += new System.EventHandler(this.BtnElegirTrailer_Click);
            // 
            // TbxRutaTrailer
            // 
            this.TbxRutaTrailer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxRutaTrailer.DefaultText = "";
            this.TbxRutaTrailer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxRutaTrailer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxRutaTrailer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxRutaTrailer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxRutaTrailer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxRutaTrailer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxRutaTrailer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxRutaTrailer.Location = new System.Drawing.Point(277, 421);
            this.TbxRutaTrailer.Name = "TbxRutaTrailer";
            this.TbxRutaTrailer.PasswordChar = '\0';
            this.TbxRutaTrailer.PlaceholderText = "";
            this.TbxRutaTrailer.ReadOnly = true;
            this.TbxRutaTrailer.SelectedText = "";
            this.TbxRutaTrailer.Size = new System.Drawing.Size(200, 36);
            this.TbxRutaTrailer.TabIndex = 48;
            // 
            // OfdTrailer
            // 
            this.OfdTrailer.FileName = "openFileDialog1";
            // 
            // WmpTrailer
            // 
            this.WmpTrailer.Enabled = true;
            this.WmpTrailer.Location = new System.Drawing.Point(277, 472);
            this.WmpTrailer.Name = "WmpTrailer";
            this.WmpTrailer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpTrailer.OcxState")));
            this.WmpTrailer.Size = new System.Drawing.Size(313, 112);
            this.WmpTrailer.TabIndex = 46;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(29, 333);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(52, 17);
            this.guna2HtmlLabel6.TabIndex = 49;
            this.guna2HtmlLabel6.Text = "Imagen:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(277, 400);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(47, 17);
            this.guna2HtmlLabel7.TabIndex = 50;
            this.guna2HtmlLabel7.Text = "Trailer:";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Red;
            this.guna2VSeparator1.FillThickness = 5;
            this.guna2VSeparator1.Location = new System.Drawing.Point(718, 14);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(11, 570);
            this.guna2VSeparator1.TabIndex = 51;
            // 
            // UC_Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.TbxRutaTrailer);
            this.Controls.Add(this.BtnElegirTrailer);
            this.Controls.Add(this.WmpTrailer);
            this.Controls.Add(this.BtnElegirImagen);
            this.Controls.Add(this.PctbxImagen);
            this.Controls.Add(this.CterHorariosPelicula);
            this.Controls.Add(this.CterGeneros);
            this.Controls.Add(this.CbxPelicula);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.CbxSala);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.TbxFecha);
            this.Controls.Add(this.guna2HtmlLabel16);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.CbxGeneros);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.CbxRestriccionEdad);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.TbxRutaPortada);
            this.Controls.Add(this.TbxDuracion);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.TbxEstreno);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BtnCrearPelicula);
            this.Name = "UC_Peliculas";
            this.Size = new System.Drawing.Size(1353, 598);
            this.Load += new System.EventHandler(this.UC_Peliculas_Load);
            this.Enter += new System.EventHandler(this.UC_Peliculas_Enter);
            this.Leave += new System.EventHandler(this.UC_Peliculas_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.PctbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WmpTrailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnCrearPelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TbxNombre;
        private Guna.UI2.WinForms.Guna2TextBox TbxDescripcion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox TbxDuracion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox TbxEstreno;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox TbxRutaPortada;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox CbxRestriccionEdad;
        private Guna.UI2.WinForms.Guna2ComboBox CbxGeneros;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2ComboBox CbxPelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CbxSala;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2TextBox TbxFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2Button BtnAsignar;
        private Guna.UI2.WinForms.Guna2ContainerControl CterGeneros;
        private Guna.UI2.WinForms.Guna2ContainerControl CterHorariosPelicula;
        private System.Windows.Forms.OpenFileDialog OfdImagenPeli;
        private Guna.UI2.WinForms.Guna2PictureBox PctbxImagen;
        private Guna.UI2.WinForms.Guna2Button BtnElegirImagen;
        private AxWMPLib.AxWindowsMediaPlayer WmpTrailer;
        private Guna.UI2.WinForms.Guna2Button BtnElegirTrailer;
        private Guna.UI2.WinForms.Guna2TextBox TbxRutaTrailer;
        private System.Windows.Forms.OpenFileDialog OfdTrailer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}
