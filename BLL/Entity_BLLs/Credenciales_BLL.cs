using BE;
using DAL.Entity_Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Credenciales_BLL : Base_BLL<Credenciales>
    {
        private readonly Credenciales_Mapper credenciales_Mapper = new Credenciales_Mapper();

        public DataTable IniciarSesion(Credenciales credenciales) => credenciales_Mapper.IniciarSesion(credenciales);
    }
}
