﻿namespace UI.FRM_ADMIN
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
            this.BtnCrearPelicula = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbxDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxDuracion = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxEstreno = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxTrailer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxPortada = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxIDRest = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbxIDGenero1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxIDGenero2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxPelicula = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CbxSala = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxHoraInicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbxFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnAsignar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // BtnCrearPelicula
            // 
            this.BtnCrearPelicula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearPelicula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCrearPelicula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCrearPelicula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCrearPelicula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCrearPelicula.ForeColor = System.Drawing.Color.White;
            this.BtnCrearPelicula.Location = new System.Drawing.Point(393, 386);
            this.BtnCrearPelicula.Name = "BtnCrearPelicula";
            this.BtnCrearPelicula.Size = new System.Drawing.Size(180, 45);
            this.BtnCrearPelicula.TabIndex = 0;
            this.BtnCrearPelicula.Text = "CREAR PELICULA";
            this.BtnCrearPelicula.Click += new System.EventHandler(this.BtnCrearPelicula_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(43, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(43, 15);
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
            this.TbxNombre.Location = new System.Drawing.Point(92, 14);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.PasswordChar = '\0';
            this.TbxNombre.PlaceholderText = "";
            this.TbxNombre.SelectedText = "";
            this.TbxNombre.Size = new System.Drawing.Size(200, 36);
            this.TbxNombre.TabIndex = 2;
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxDescripcion.DefaultText = "";
            this.TbxDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxDescripcion.Location = new System.Drawing.Point(92, 72);
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
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(24, 203);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(62, 15);
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
            this.TbxDuracion.Location = new System.Drawing.Point(92, 287);
            this.TbxDuracion.Name = "TbxDuracion";
            this.TbxDuracion.PasswordChar = '\0';
            this.TbxDuracion.PlaceholderText = "";
            this.TbxDuracion.SelectedText = "";
            this.TbxDuracion.Size = new System.Drawing.Size(200, 36);
            this.TbxDuracion.TabIndex = 10;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(39, 308);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(49, 15);
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
            this.TbxEstreno.Location = new System.Drawing.Point(92, 236);
            this.TbxEstreno.Name = "TbxEstreno";
            this.TbxEstreno.PasswordChar = '\0';
            this.TbxEstreno.PlaceholderText = "";
            this.TbxEstreno.SelectedText = "";
            this.TbxEstreno.Size = new System.Drawing.Size(200, 36);
            this.TbxEstreno.TabIndex = 8;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(44, 257);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(42, 15);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "Estreno:";
            // 
            // TbxTrailer
            // 
            this.TbxTrailer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxTrailer.DefaultText = "";
            this.TbxTrailer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxTrailer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxTrailer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxTrailer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxTrailer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxTrailer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxTrailer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxTrailer.Location = new System.Drawing.Point(92, 395);
            this.TbxTrailer.Name = "TbxTrailer";
            this.TbxTrailer.PasswordChar = '\0';
            this.TbxTrailer.PlaceholderText = "";
            this.TbxTrailer.SelectedText = "";
            this.TbxTrailer.Size = new System.Drawing.Size(200, 36);
            this.TbxTrailer.TabIndex = 14;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(51, 416);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(35, 15);
            this.guna2HtmlLabel6.TabIndex = 13;
            this.guna2HtmlLabel6.Text = "Trailer:";
            // 
            // TbxPortada
            // 
            this.TbxPortada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxPortada.DefaultText = "";
            this.TbxPortada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxPortada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxPortada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPortada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxPortada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPortada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxPortada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxPortada.Location = new System.Drawing.Point(92, 344);
            this.TbxPortada.Name = "TbxPortada";
            this.TbxPortada.PasswordChar = '\0';
            this.TbxPortada.PlaceholderText = "";
            this.TbxPortada.SelectedText = "";
            this.TbxPortada.Size = new System.Drawing.Size(200, 36);
            this.TbxPortada.TabIndex = 12;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(45, 365);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel7.TabIndex = 11;
            this.guna2HtmlLabel7.Text = "Portada:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(302, 257);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(101, 15);
            this.guna2HtmlLabel8.TabIndex = 15;
            this.guna2HtmlLabel8.Text = "Restriccion de edad:";
            // 
            // CbxIDRest
            // 
            this.CbxIDRest.BackColor = System.Drawing.Color.Transparent;
            this.CbxIDRest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxIDRest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxIDRest.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDRest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDRest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxIDRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxIDRest.ItemHeight = 30;
            this.CbxIDRest.Items.AddRange(new object[] {
            "1"});
            this.CbxIDRest.Location = new System.Drawing.Point(409, 236);
            this.CbxIDRest.Name = "CbxIDRest";
            this.CbxIDRest.Size = new System.Drawing.Size(164, 36);
            this.CbxIDRest.TabIndex = 16;
            // 
            // CbxIDGenero1
            // 
            this.CbxIDGenero1.BackColor = System.Drawing.Color.Transparent;
            this.CbxIDGenero1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxIDGenero1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxIDGenero1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDGenero1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDGenero1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxIDGenero1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxIDGenero1.ItemHeight = 30;
            this.CbxIDGenero1.Items.AddRange(new object[] {
            "2"});
            this.CbxIDGenero1.Location = new System.Drawing.Point(409, 282);
            this.CbxIDGenero1.Name = "CbxIDGenero1";
            this.CbxIDGenero1.Size = new System.Drawing.Size(164, 36);
            this.CbxIDGenero1.TabIndex = 18;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(353, 303);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel9.TabIndex = 17;
            this.guna2HtmlLabel9.Text = "Genero 1:";
            // 
            // CbxIDGenero2
            // 
            this.CbxIDGenero2.BackColor = System.Drawing.Color.Transparent;
            this.CbxIDGenero2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxIDGenero2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxIDGenero2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDGenero2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxIDGenero2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxIDGenero2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxIDGenero2.ItemHeight = 30;
            this.CbxIDGenero2.Items.AddRange(new object[] {
            "3"});
            this.CbxIDGenero2.Location = new System.Drawing.Point(409, 324);
            this.CbxIDGenero2.Name = "CbxIDGenero2";
            this.CbxIDGenero2.Size = new System.Drawing.Size(164, 36);
            this.CbxIDGenero2.TabIndex = 20;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(353, 344);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel10.TabIndex = 19;
            this.guna2HtmlLabel10.Text = "Genero 2:";
            // 
            // CbxPelicula
            // 
            this.CbxPelicula.BackColor = System.Drawing.Color.Transparent;
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
            this.CbxPelicula.Location = new System.Drawing.Point(829, 108);
            this.CbxPelicula.Name = "CbxPelicula";
            this.CbxPelicula.Size = new System.Drawing.Size(200, 36);
            this.CbxPelicula.TabIndex = 39;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(780, 129);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(43, 15);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "Pelicula:";
            // 
            // CbxSala
            // 
            this.CbxSala.BackColor = System.Drawing.Color.Transparent;
            this.CbxSala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSala.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxSala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbxSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbxSala.ItemHeight = 30;
            this.CbxSala.Items.AddRange(new object[] {
            "1"});
            this.CbxSala.Location = new System.Drawing.Point(829, 57);
            this.CbxSala.Name = "CbxSala";
            this.CbxSala.Size = new System.Drawing.Size(200, 36);
            this.CbxSala.TabIndex = 37;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(796, 78);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(27, 15);
            this.guna2HtmlLabel11.TabIndex = 36;
            this.guna2HtmlLabel11.Text = "Sala:";
            // 
            // TbxHoraInicio
            // 
            this.TbxHoraInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxHoraInicio.DefaultText = "";
            this.TbxHoraInicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbxHoraInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbxHoraInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxHoraInicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbxHoraInicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbxHoraInicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbxHoraInicio.Location = new System.Drawing.Point(829, 215);
            this.TbxHoraInicio.Name = "TbxHoraInicio";
            this.TbxHoraInicio.PasswordChar = '\0';
            this.TbxHoraInicio.PlaceholderText = "";
            this.TbxHoraInicio.SelectedText = "";
            this.TbxHoraInicio.Size = new System.Drawing.Size(200, 36);
            this.TbxHoraInicio.TabIndex = 29;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(755, 236);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(68, 15);
            this.guna2HtmlLabel15.TabIndex = 28;
            this.guna2HtmlLabel15.Text = "Horario Inicio:";
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
            this.TbxFecha.Location = new System.Drawing.Point(829, 164);
            this.TbxFecha.Name = "TbxFecha";
            this.TbxFecha.PasswordChar = '\0';
            this.TbxFecha.PlaceholderText = "";
            this.TbxFecha.SelectedText = "";
            this.TbxFecha.Size = new System.Drawing.Size(200, 36);
            this.TbxFecha.TabIndex = 27;
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(787, 185);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(36, 15);
            this.guna2HtmlLabel16.TabIndex = 26;
            this.guna2HtmlLabel16.Text = "Fecha:";
            // 
            // BtnAsignar
            // 
            this.BtnAsignar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsignar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsignar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAsignar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAsignar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAsignar.ForeColor = System.Drawing.Color.White;
            this.BtnAsignar.Location = new System.Drawing.Point(1078, 129);
            this.BtnAsignar.Name = "BtnAsignar";
            this.BtnAsignar.Size = new System.Drawing.Size(180, 45);
            this.BtnAsignar.TabIndex = 21;
            this.BtnAsignar.Text = "ASIGNAR PELICULA";
            this.BtnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(755, 303);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(467, 15);
            this.guna2HtmlLabel12.TabIndex = 40;
            this.guna2HtmlLabel12.Text = "Al seleccionar sala, pelicula y establecer fecha, se deben de obtener todos los h" +
    "orarios disponibles";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(755, 324);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(324, 15);
            this.guna2HtmlLabel13.TabIndex = 41;
            this.guna2HtmlLabel13.Text = "en intervalos de duracion de la pelicula y un adicional de 30 minutos";
            // 
            // UC_Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.CbxPelicula);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.CbxSala);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.TbxHoraInicio);
            this.Controls.Add(this.guna2HtmlLabel15);
            this.Controls.Add(this.TbxFecha);
            this.Controls.Add(this.guna2HtmlLabel16);
            this.Controls.Add(this.BtnAsignar);
            this.Controls.Add(this.CbxIDGenero2);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.CbxIDGenero1);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.CbxIDRest);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.TbxTrailer);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.TbxPortada);
            this.Controls.Add(this.guna2HtmlLabel7);
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
            this.Size = new System.Drawing.Size(1353, 447);
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
        private Guna.UI2.WinForms.Guna2TextBox TbxTrailer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox TbxPortada;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox CbxIDRest;
        private Guna.UI2.WinForms.Guna2ComboBox CbxIDGenero1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2ComboBox CbxIDGenero2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2ComboBox CbxPelicula;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox CbxSala;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2TextBox TbxHoraInicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2TextBox TbxFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2Button BtnAsignar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
    }
}