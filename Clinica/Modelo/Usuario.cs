using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private String user;
        private String password;
        public enum Rol
        {
            DIRECCION,
            ADMINISTRATIVO,
            ADMINISTRADOR,
            PERSONAL_SANITARIO
        }

        public Usuario(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
        
    }
}
