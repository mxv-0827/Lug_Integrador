using BE;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace UI.Extras
{
    public class GestionHorarios
    {
        public static void MostrarHorarios(Guna2ContainerControl cter, TimeSpan duracionPelicula, List<HorarioPeliculas> lstHorariosOcupados)
        {
            List<TimeSpan> horariosDisponibles = new List<TimeSpan>();

            TimeSpan horaApertura = new TimeSpan(7, 0, 0);
            TimeSpan horaCierre = new TimeSpan(23, 0, 0);

            TimeSpan tiempoLimpieza = new TimeSpan(0, 30, 0);

            TimeSpan horaActual = horaApertura; //Empieza en el horario de apertura => 7AM.

            //---------------------------------------------------------------------------------------------------------------------------------------

            while (horaActual + duracionPelicula <= horaCierre)
            {
                if (lstHorariosOcupados.Count == 0)
                {
                    horariosDisponibles.Add(horaActual);
                    horaActual = horaActual.Add(duracionPelicula + tiempoLimpieza);
                }

                else 
                {
                    int posibilidadDisponibilidad = 0;

                    foreach (HorarioPeliculas horPeli in lstHorariosOcupados)
                    {
                        if (horaActual + duracionPelicula <= horPeli.HoraInicio - tiempoLimpieza || horaActual >= horPeli.HoraFin + tiempoLimpieza)
                        {
                            posibilidadDisponibilidad++;
                        }

                        else
                        {
                            horaActual = horPeli.HoraFin.Add(tiempoLimpieza);
                            break;
                        }
                    }

                    if (posibilidadDisponibilidad == lstHorariosOcupados.Count)
                    {
                        horariosDisponibles.Add(horaActual); //Osea, si el horario no se interpone con un registro de horarios, se agrega.
                        horaActual = horaActual.Add(duracionPelicula + tiempoLimpieza);
                    }
                }
            }

            int locationX = 50, locationY = 14;

            foreach (TimeSpan horario in horariosDisponibles)
            {
                Guna2RadioButton rdb = new Guna2RadioButton
                {
                    Location = new Point(locationX, locationY),
                    Text = string.Format("{0:D2}:{1:D2}", horario.Hours, horario.Minutes),
                    BackColor = Color.Transparent
                };

                cter.Controls.Add(rdb);

                locationX += 165;

                if (locationX >= 490)
                {
                    locationX = 50;
                    locationY += 34;
                }
            }
        }
    }
}
