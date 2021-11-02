using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio2
    {
        public String calcular_letra_dni(int dni)
        {
          
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            int mod = 0;
            if (dni.ToString().Length == 8)
            {
                
                 mod = dni % 23;
               
            }

            return control[mod];
        }
     
    }
}
