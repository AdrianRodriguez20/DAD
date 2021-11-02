using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio9
    {
        public void randomNum()
        {
            Dictionary<int, int> listadonumeros = new Dictionary<int, int>();
            var rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int num = rnd.Next(1,10);

                if (!listadonumeros.ContainsKey(num))
                {
                    listadonumeros.Add(num, 1);
                    Console.WriteLine("El número : " +  num + " es nuevo");
                }
                else
                {
                    listadonumeros[num] += 1;
                    Console.WriteLine("El número : " + num + " está repetido " + listadonumeros[num]);
                }


            }
        }
     
    }
}
