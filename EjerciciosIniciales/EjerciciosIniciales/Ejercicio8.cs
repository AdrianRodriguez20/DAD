using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio8
    {

       public void calcular()
        {
            int opcion ;
            do
            {

                Console.WriteLine("Inserte el valor A");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el valor B");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("--------Calculadora-------");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.WriteLine("--------------------------");
                 opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Esta calculadora no soporta este calculo");
                        break;
                }
            } while (opcion != 5);
        }
    }

}
