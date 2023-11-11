using BE;
using BE.Tabla_Intermedia;
using BLL;
using BLL.Entity_BLLs;
using BLL.Transactions_BLLs;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Extras;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UI.FRM_ADMIN
{
    public partial class UC_Peliculas : UserControl
    {
        public UC_Peliculas()
        {
            InitializeComponent();
        }

        int locationX = 3;
        private void CrearGunaChip(string genero)
        {
            Guna2Chip chip = new Guna2Chip
            {
                Location = new Point(locationX, 3),
                Size = new Size(130, 40),
                UseTransparentBackground = true,
                Text = genero,
            };

            chip.Click += ChipProd_Click;

            locationX += 133;

            CterGeneros.Controls.Add(chip);
        }

        
        private void ObtenerGenerosCBX()
        {
            generosObtenidos = Base_BLL_Generos.ObtenerTodasEntidades("Generos");

            CbxGeneros.SelectedIndexChanged -= CbxGeneros_SelectedIndexChanged;
            foreach (DataRow row in generosObtenidos.Rows)
            {
                CbxGeneros.Items.Add(row["Nombre"].ToString());
            }
            CbxGeneros.SelectedIndexChanged += CbxGeneros_SelectedIndexChanged;
        }

        private void ReiniciarGenerosCBX()
        {
            CbxGeneros.SelectedIndexChanged -= CbxGeneros_SelectedIndexChanged;
            CbxGeneros.Items.Clear();
            CbxGeneros.SelectedIndex = -1;
            CbxGeneros.SelectedIndexChanged += CbxGeneros_SelectedIndexChanged;

            generosAgregados.Clear();
            CterGeneros.Controls.Clear();

            locationX = 3;
        }

        private void ObtenerPeliculasCBX()
        {
            CbxPelicula.SelectedIndexChanged -= CbxPelicula_SelectedIndexChanged;
            CbxPelicula.DataSource = Base_BLL_Peliculas.ObtenerTodasEntidades("Peliculas");
            CbxPelicula.SelectedIndex = -1;
            CbxPelicula.SelectedIndexChanged += CbxPelicula_SelectedIndexChanged;

            CbxPelicula.DisplayMember = "Nombre";
            CbxPelicula.ValueMember = "ID";
        }

        private void ReiniciarPeliculasCBX()
        {
            CbxPelicula.SelectedIndexChanged -= CbxPelicula_SelectedIndexChanged;
            CbxPelicula.DataSource = null;
            CbxPelicula.SelectedIndex = -1;
            CbxPelicula.SelectedIndexChanged += CbxPelicula_SelectedIndexChanged;
        }


        private void MostrarHorariosDisponibles()
        {
            DateTime fechaElegida;

            if(!string.IsNullOrEmpty(CbxSala.Text) && !string.IsNullOrEmpty(CbxPelicula.Text) && DateTime.TryParseExact(TbxFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaElegida))
            {
                CterHorariosPelicula.Controls.Clear();

                pelicula = new Peliculas();
                pelicula = (Peliculas)Base_BLL_Peliculas.ObtenerEntidadPorId(pelicula.GetType().Name, int.Parse(CbxPelicula.SelectedValue.ToString())).Rows[0];

                //Obtenemos todos los horarios que abarquen a esa fecha y sala escogidos.

                DataTable disponibilidadAsientosObtenidos = HorarioPeliculas_BLL.ObtenerHorariosCoincidentes(fechaElegida, int.Parse(CbxSala.SelectedValue.ToString()));
                List<HorarioPeliculas> horariosOcupados = new List<HorarioPeliculas>();

                foreach(DataRow row in disponibilidadAsientosObtenidos.Rows)
                {
                    horariosOcupados.Add((HorarioPeliculas)row);
                };

                horariosOcupados = horariosOcupados.OrderBy(objeto => objeto.HoraInicio).ToList(); //Se ordena la lista de menor a mayor en base a la prop HoraInicio
                GestionHorarios.MostrarHorarios(CterHorariosPelicula, pelicula.Duracion, horariosOcupados);
            }
        }


        //Peliculas
        Peliculas pelicula;
        Base_BLL<Peliculas> Base_BLL_Peliculas = new Base_BLL<Peliculas>();

        //Generos
        Generos genero;
        Base_BLL<Generos> Base_BLL_Generos = new Base_BLL<Generos>();

        //RestriccionesEdad
        RestriccionesEdad restriccionEdad;
        Base_BLL<RestriccionesEdad> Base_BLL_Restricciones = new Base_BLL<RestriccionesEdad>();

        //Salas
        Base_BLL<Salas> Base_BLL_Salas = new Base_BLL<Salas>();

        //Peliculas y Generos.
        GenPeli_Transaction_BLL GenPeli_Transaction_BLL = new GenPeli_Transaction_BLL();

        

        DataTable generosObtenidos; //Generos obtenidos desde la BD.
        List<Generos> generosAgregados = new List<Generos>(); //Generos que tendra la pelicula creada.

        private void UC_Peliculas_Load(object sender, EventArgs e)
        {
            ObtenerGenerosCBX();

            //--------------------------------------------------------------------------------------------------------------

            DataTable restriccionesEdadObtenidas = Base_BLL_Restricciones.ObtenerTodasEntidades("RestriccionesEdad");
            restriccionesEdadObtenidas.Columns.Add("EdadAMostrar", typeof(string));

            foreach (DataRow row in restriccionesEdadObtenidas.Rows)
            {
                restriccionEdad = (RestriccionesEdad)row;
                row["EdadAMostrar"] = $"+{restriccionEdad.Edad}";
            }

            CbxRestriccionEdad.DataSource = restriccionesEdadObtenidas;
            CbxRestriccionEdad.DisplayMember = "EdadAMostrar";
            CbxRestriccionEdad.ValueMember = "ID";

            CbxRestriccionEdad.SelectedIndex = -1;

            //--------------------------------------------------------------------------------------------------------------

            ObtenerPeliculasCBX();
        }


        private void UC_Peliculas_Enter(object sender, EventArgs e)
        {
            CbxSala.DataSource = null;

            CbxSala.SelectedIndexChanged -= CbxSala_SelectedIndexChanged;
            CbxSala.DataSource = Base_BLL_Salas.ObtenerTodasEntidades("Salas");
            CbxSala.SelectedIndex = -1;
            CbxSala.SelectedIndexChanged += CbxSala_SelectedIndexChanged;

            CbxSala.DisplayMember = "Nombre";
            CbxSala.ValueMember = "ID";
        }


        private void CbxGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrearGunaChip(CbxGeneros.Text);

            genero = (Generos)generosObtenidos.AsEnumerable().First(row => row["Nombre"].ToString() == CbxGeneros.Text);
            generosAgregados.Add(genero);

            CbxGeneros.SelectedIndexChanged -= CbxGeneros_SelectedIndexChanged;
            CbxGeneros.Items.Remove(CbxGeneros.Text);
            CbxGeneros.SelectedIndex = -1;
            CbxGeneros.SelectedIndexChanged += CbxGeneros_SelectedIndexChanged;
        }


        private void ChipProd_Click(object sender, EventArgs e)
        {
            Guna2Chip chipABorrar = (Guna2Chip)sender;

            //El chip al hacerle click ya se borra solo. No necesita codearse.

            foreach (Guna2Chip chip in CterGeneros.Controls)
            {
                if (chip.Location.X > chipABorrar.Location.X) chip.Location = new Point(chip.Location.X - 133, 3);
            }

            locationX -= 133;

            genero = (Generos)generosObtenidos.AsEnumerable().First(row => row["Nombre"].ToString() == chipABorrar.Text);
            generosAgregados.Remove(genero);

            CbxGeneros.Items.Add(genero.Nombre);
        }


        private void BtnCrearPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                int horas = int.Parse(TbxDuracion.Text) / 60; //Obtenemos la cantidad de horas.
                int minutos = int.Parse(TbxDuracion.Text) % 60; //El resto son los minutos restantes.


                pelicula = new Peliculas
                {
                    Nombre = TbxNombre.Text,
                    Descripcion = TbxDescripcion.Text,
                    Estreno = DateTime.ParseExact(TbxEstreno.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Duracion = new TimeSpan(horas, minutos, 0),
                    Portada = "nada",
                    Trailer = "nada",
                    IDRestriccion = int.Parse(CbxRestriccionEdad.SelectedValue.ToString())
                };

                GenPeli_Transaction_BLL.AgregarEntidad(pelicula, generosAgregados);

                ReiniciarGenerosCBX();
                ObtenerGenerosCBX();

                ReiniciarPeliculasCBX();
                ObtenerPeliculasCBX();

                MessageBox.Show("Pelicula creada exitosamente.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //HorarioPelicula
        HorarioPeliculas horarioPelicula;
        HorarioPeliculas_BLL HorarioPeliculas_BLL = new HorarioPeliculas_BLL();

        //HorarioPelicula y DisponibilidadAsientos
        HorPelDispoAsi_Transaction_BLL HorPelDispoAsi_Transaction_BLL = new HorPelDispoAsi_Transaction_BLL();


        private void CbxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarHorariosDisponibles();
        }


        private void CbxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarHorariosDisponibles();
        }

        private void TbxFecha_TextChanged(object sender, EventArgs e)
        {
            MostrarHorariosDisponibles();
        }


        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Guna2RadioButton rdbHorarioSeleccionado = CterHorariosPelicula.Controls
                    .OfType<Guna2RadioButton>()
                    .FirstOrDefault(rdb => rdb.Checked);

                horarioPelicula = new HorarioPeliculas
                {
                    IDSala = int.Parse(CbxSala.SelectedValue.ToString()),
                    IDPelicula = int.Parse(CbxPelicula.SelectedValue.ToString()),
                    Fecha = DateTime.ParseExact(TbxFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    HoraInicio = TimeSpan.ParseExact(rdbHorarioSeleccionado.Text, "hh\\:mm", CultureInfo.InvariantCulture)
                };

                HorPelDispoAsi_Transaction_BLL.AgregarEntidad(horarioPelicula);

                MessageBox.Show("Horario almacenado correctamente.");

                CbxSala.SelectedIndex = -1;
                CbxPelicula.SelectedIndex = -1;
                TbxFecha.Clear();
                CterHorariosPelicula.Controls.Clear();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void UC_Peliculas_Leave(object sender, EventArgs e)
        {
            ReiniciarGenerosCBX();
        }

        
    }
}
