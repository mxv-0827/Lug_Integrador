using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Usuarios_BLL : Base_BLL<Usuarios>
    {
        

        public override int AgregarEntidad(Usuarios usuarios) //Usuarios no requiere de ser asignado un ID
        {
            string spNombre = ObtenerNombreSP("Agregar", usuarios.GetType().Name);
            return mapper.Agregar(usuarios, spNombre);
        }
    }
}
