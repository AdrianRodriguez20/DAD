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
        private int active;

        public Usuario()
        {
        }

        public Usuario(string username, string password, string role , int active)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.Active = active;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
  
        public int Active { get => active; set => active = value; }
        public string Role { get => role; set => role = value; }
    }
}
