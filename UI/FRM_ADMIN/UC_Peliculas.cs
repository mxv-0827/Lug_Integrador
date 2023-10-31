using BE;
using BLL.Transactions_BLLs;
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

namespace UI.FRM_ADMIN
{
    public partial class UC_Peliculas : UserControl
    {
        public UC_Peliculas()
        {
            InitializeComponent();
        }

        //Peliculas
        Peliculas pelicula;

        //Peliculas y Generos.
        GenPeli_Transaction_BLL GenPeli_Transaction_BLL = new GenPeli_Transaction_BLL();


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
                    IDRestriccion = int.Parse(CbxIDRest.Text)
                };

                GenPeli_Transaction_BLL.AgregarEntidad(pelicula, new List<int> { int.Parse(CbxIDGenero1.Text), int.Parse(CbxIDGenero2.Text) });

                MessageBox.Show("Pelicula creada exitosamente.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //HorarioPelicula
        HorarioPeliculas horarioPelicula;

        //HorarioPelicula y DisponibilidadAsientos
        HorPelDispoAsi_Transaction_BLL HorPelDispoAsi_Transaction_BLL = new HorPelDispoAsi_Transaction_BLL();


        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                horarioPelicula = new HorarioPeliculas
                {
                    IDSala = int.Parse(CbxSala.Text),
                    IDPelicula = int.Parse(CbxPelicula.Text),
                    Fecha = DateTime.ParseExact(TbxFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    HoraInicio = TimeSpan.ParseExact(TbxHoraInicio.Text, "hh\\:mm", CultureInfo.InvariantCulture)
                };

                HorPelDispoAsi_Transaction_BLL.AgregarEntidad(horarioPelicula);

                MessageBox.Show("Horario almacenado correctamente.");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
