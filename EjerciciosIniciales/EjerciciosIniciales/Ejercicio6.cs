using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio6
    {
        public void buscadorNum()
        {
            int num;
            SortedDictionary<int, int> listadonumeros =  new SortedDictionary<int, int>();
            do
            {
                Console.WriteLine("Inserte Numeros: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (!listadonumeros.ContainsKey(num))
                {
                    listadonumeros.Add(num, 1);

                } 
                else
                {
                    listadonumeros[num] +=1;
                }

            } while (num != -1);
            listadonumeros.Remove(-1);
            Console.WriteLine("El número menor: "+ listadonumeros.Keys.Min());
            Console.WriteLine("El número mayor: "+ listadonumeros.Keys.Max());
            Console.WriteLine("El número más repetido: " + listadonumeros.Values.Max());
        }
    }
}
