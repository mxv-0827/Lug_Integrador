using BE;
using SEC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class Credenciales_BLL : Base_BLL
    {
        public DataTable IniciarSesion(Credenciales credenciales) 
        {
            credenciales.Password = Password_Encriptador.EncriptarContraseña(credenciales.Password, credenciales.Email);
            return base.EjecutarConsultaEspecifica<DataTable>("Iniciar_Sesion", new { credenciales.Email, credenciales.Password });
        } 
    }
}
