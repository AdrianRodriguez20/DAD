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
        private String role;

        public Usuario()
        {
        }

        public Usuario(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        
    }
}
