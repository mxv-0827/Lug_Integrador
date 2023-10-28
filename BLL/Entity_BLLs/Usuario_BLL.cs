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
    public class Usuario_BLL
    {
        private readonly Usuario_Mapper usuario_Mapper = new Usuario_Mapper();


        public DataTable IniciarSesion(Usuario_Logueo usuarioLogueo) => usuario_Mapper.IniciarSesion(usuarioLogueo);
    }
}
