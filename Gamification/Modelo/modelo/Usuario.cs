using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.modelo
{
    public class Usuario
    {
        private String username;
        private String password;
        private String rol;

        public Usuario()
        {
        }

        public Usuario(string username, string password, string rol)
        {
            this.Username = username;
            this.Password = password;
            this.Rol = rol;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
