using System;
using System.Collections;
using System.Collections.Generic;


namespace EjerciciosAEUT3
{
    class Program
    {

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("EJERCICIOS INICIALES C #");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Ejercico 1A");
                Console.WriteLine("2. Ejercico 1B");
                Console.WriteLine("3. Ejercico 2");
                Console.WriteLine("4. Ejercico 3");
                Console.WriteLine("5. Ejercico 4");
                Console.WriteLine("6. Salir");
                Console.WriteLine("--------------------------");
                Console.Write("Inserte la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                      
                        Ejercicio1A ej1A = new Ejercicio1A();
                        ej1A.diasHasta();
                        break;

                    case 2:
                    
                        Ejercicio1B ej1B = new Ejercicio1B();
                        ej1B.diasHasta();
                        break;

                    case 3:
                        Ejercicio2 ej2 = new Ejercicio2(); 
                        ej2.gestorTexto();
                        break;

                    case 4:
                       
                         Ejercicio3 ej3 = new Ejercicio3(); 
                         ej3.appBinformatica();
                        break;
                    
                    case 5:
                         Ejercicio4 ej4 = new Ejercicio4();
                         ej4.predicciones();
                         
                        break;
                    case 6:
                        Console.WriteLine("Adios");
                     
                        break;
                    default:

                            Console.WriteLine("El ejercicio seleccionado no existe");

                        break;
                }


            } while (opcion != 6);
        }
    }
 }







