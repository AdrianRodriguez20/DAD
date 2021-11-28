using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.modelo
{
    public class Usuario
    {
        private int numberStaff;
        private String password;
        
        public Usuario() {
        }

        public Usuario(int numberStaff, String password)
        {
            this.numberStaff = numberStaff;
            this.password = password;
        }
        
        public int NumberStaff { get => numberStaff; set => numberStaff = value; }
        public string Password { get => password; set => password = value; }
        


    }
}
