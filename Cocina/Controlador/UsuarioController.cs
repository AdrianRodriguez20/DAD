using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.ado;
using Modelo.modelo;

namespace Controlador
{
    public class UsuarioController
    {
        UsuarioADO usuarioADO = new UsuarioADO();
        public string Login(string user, string password)
        {
            Usuario usuario = null;
            String rol = "";
            if (user != null && !user.Trim().Equals("") && password != null && !password.Trim().Equals(""))
            {
                if (usuarioADO.findById(user) != null)
                {
                    if (usuarioADO.findById(user).Password.Equals(password))
                    {
                        usuario = usuarioADO.findById(user);
                    }
                }

            }
            return usuario != null ? usuario.Role : null;
        }
    }
}
