using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using BLL.Entity_BLLs;
using Guna.UI2.WinForms;
using UI.Extras;

namespace UI.FRM_CLIENTE
{
    public partial class UC_Pelicula : UserControl
    {
        public UC_Pelicula()
        {
            InitializeComponent();
        }


        public Peliculas Pelicula { get; set; } //pelicula a mostrar en todo el UC.


        Base_BLL Base_BLL = new Base_BLL();

        Generos_BLL Generos_BLL = new Generos_BLL();

        HorarioPeliculas_BLL HorarioPeliculas_BLL = new HorarioPeliculas_BLL();


        private void CrearLBLsGeneros(string genero, int locationY)
        {
            Guna2HtmlLabel lbl = new Guna2HtmlLabel
            {
                Location = new Point(880, locationY),
                Text = genero,
                Font = new Font("Segoe UI", 9.75f, FontStyle.Bold)
            };

            this.Controls.Add(lbl);
        }

        private void CrearLBLSinHorarios()
        {
            Guna2HtmlLabel lbl1 = new Guna2HtmlLabel
            {
                Location = new Point(582, 352),
                Size = new Size(86, 34),
                Text = "No hay",
                Font = new Font("Segoe UI Black", 18f, FontStyle.Bold),
                ForeColor = Color.Red,
                BackColor = Color.Transparent
            };

            Guna2HtmlLabel lbl2 = new Guna2HtmlLabel
            {
                Location = new Point(504, 392),
                Size = new Size(249, 34),
                Text = "horarios disponibles!",
                Font = new Font("Segoe UI Black", 18f, FontStyle.Bold),
                ForeColor = Color.Red,
                BackColor = Color.Transparent
            };

            this.Controls.Add(lbl1);
            this.Controls.Add(lbl2);

            lbl1.BringToFront();
            lbl2.BringToFront();

        }

        private void UC_Pelicula_Enter(object sender, EventArgs e)
        {
             
            PctbxPelicula.Image = Imagen_Convertidor.HexaAImg(Pelicula.Portada);
            LblNombre.Text = Pelicula.Nombre;
            LblFecha.Text = $"{Pelicula.Estreno.Day}/{Pelicula.Estreno.Month}/{Pelicula.Estreno.Year}";
            LblDuracion.Text = $"{Pelicula.Duracion.TotalMinutes} minutos";
            TbxDescripcion.Text = Pelicula.Descripcion;
            WmpTrailer.URL = Pelicula.Trailer;
            WmpTrailer.close();

            DataTable tableGeneros = Generos_BLL.ObtenerGenerosPorIdPelicula(Pelicula.ID);
            tableGeneros.Columns.Add("NombreGenero", typeof(string));

            int locationY = 67; //Ubicacion de Y del primer genero;

            for(int i = 0; i < tableGeneros.Rows.Count; i++)
            {
                int idGenero = (int)tableGeneros.Rows[i]["IDGenero"];
                tableGeneros.Rows[i]["NombreGenero"] = Generos_BLL.ObtenerEntidadPorId("Generos", idGenero).Rows[0]["Nombre"]; //Asigna solo el nombre del genero segun su ID.
                string nombreGenero = tableGeneros.Rows[i]["NombreGenero"].ToString();

                CrearLBLsGeneros(nombreGenero, locationY);
                locationY += 24;
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            DataTable tableHorarios = HorarioPeliculas_BLL.ObtenerHorariosPorFechaYPelicula(Pelicula.ID); //Fecha actual => DateTime.Now
            List<object> lstHorariosModificado = new List<object>();

            if(tableHorarios.Rows.Count == 0)
            {
                CrearLBLSinHorarios();
            }

            else
            {
                foreach (DataRow row in tableHorarios.Rows)
                {
                    object horario = new
                    {
                        Sala = Base_BLL.ObtenerEntidadPorId("Salas", (int)row["IDSala"]).Rows[0]["Nombre"],
                        Fecha = row["Fecha"].ToString().Substring(0, 10),
                        HoraInicio = row["HoraInicio"].ToString(),
                        HoraFin = row["HoraFin"].ToString(),
                        Precio = row["PrecioEntrada"].ToString()
                    };

                    lstHorariosModificado.Add(horario);
                }

                DgvHorariosPelicula.DataSource = null;
                DgvHorariosPelicula.DataSource = lstHorariosModificado;
                DgvHorariosPelicula.Columns["Precio"].Visible = false;
                DgvHorariosPelicula.ClearSelection();

                int counter = 0;
                foreach (DataGridViewRow row in DgvHorariosPelicula.Rows)
                {
                    row.Tag = (HorarioPeliculas)tableHorarios.Rows[counter]; //A cada row se le asigna el objeto HorarioPeliculas correspondiente.
                    counter++;
                }
            }
           
        }

        private void DgvHorariosPelicula_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) DgvHorariosPelicula.Cursor = Cursors.Hand;
        }

        private void DgvHorariosPelicula_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) DgvHorariosPelicula.Cursor = Cursors.Default;
        }

        private void DgvHorariosPelicula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DgvHorariosPelicula.Rows[e.RowIndex];

                Frm_Compra frm = (Frm_Compra)this.Parent;

                UC_HorarioPelicula uc_horarioPelicula =  (UC_HorarioPelicula)frm.Controls.Find("uC_HorarioPelicula1", true).First();
                uc_horarioPelicula.HorarioPelicula = (HorarioPeliculas)row.Tag;

                WmpTrailer.close();

                uc_horarioPelicula.BringToFront();
                uc_horarioPelicula.Focus();
            }
        }

        private void UC_Pelicula_Leave(object sender, EventArgs e)
        {
            WmpTrailer.close();
        }
    }
}
