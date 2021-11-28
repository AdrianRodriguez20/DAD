using Modelo.ado;
using Modelo.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioController
    {
        UsuarioADO usuarioADO = new UsuarioADO();
        public bool Login(string user, string password)
        {
            Usuario usuario = null;
            bool exito =false;
            if (user != null && !user.Trim().Equals("") && password != null && !password.Trim().Equals(""))
            {
                if (usuarioADO.findById(Convert.ToInt32(user)) != null)
                {
                    if (usuarioADO.findById(Convert.ToInt32(user)).Password.Equals(password))
                    {
                        exito = true;
                    }
                }

            }
                 return exito;
        }

    }
}
