using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio1
    {
        public void piramideVertical()
        {
            Console.WriteLine("Introduce la altura de la pirámide");
            int num = Convert.ToInt32(Console.ReadLine());
            string str = "";

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(str.PadLeft(i,'*'));
            }
            for (int j = num-1; j >= 1; j--)
            {
                Console.WriteLine(str.PadLeft(j, '*'));
            }
        }
    }
}
