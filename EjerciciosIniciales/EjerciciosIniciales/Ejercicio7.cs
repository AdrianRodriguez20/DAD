using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio7
    {
        public void adivinarNumero()
        {
            int vidas = 5;
            Console.WriteLine("Jugador A - Inserte el número Secreto ");
            int secreto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jugador B - Adivina el número Secreto ");
            do
            {
                Console.WriteLine("Insserte el número");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num<secreto)
                {
                  Console.WriteLine(num +" < Secreto");
                    vidas--;
                }else if (num > secreto)
                {
                    Console.WriteLine(num + " > Secreto");
                    vidas--;
                }
                else
                {
                    Console.WriteLine("Ganaste");
                    vidas = 0;
                }
            } while (vidas!=0);
        }
       
    }
}
