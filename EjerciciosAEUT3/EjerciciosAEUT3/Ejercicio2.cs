using System;
using System.Text.RegularExpressions;

namespace EjerciciosAEUT3
{
    public class Ejercicio2
    {
        public void gestorTexto()
        {
            Console.WriteLine("Escribe un texto");
            string texto = Console.ReadLine();
            int opcion;
            do
            {
                Console.WriteLine("1. Buscar una palabra y nos dirá cuántas veces aparece.");
                Console.WriteLine("2. Modificar una palabra y nos devolverá el texto de nuevo pero con todas las sustituciones hechas.");
                Console.WriteLine("3. Borrar una palabra y nos devolverá el texto de nuevo pero sin la palabra escogida.");
                Console.WriteLine("4. Salir");
                Console.Write("Inserte la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                string palabra;
                string expresionRegular;
                string resultado;
                switch (opcion) 
                {
                    case 1:
                  
                        Console.WriteLine("Escribe una palabra");
                        palabra = Console.ReadLine();
                        expresionRegular = @"\b" + palabra + @"\b";
                        int contador = Regex.Matches(texto,expresionRegular).Count;
                      
                        Console.WriteLine("La palabra aparece " + contador + " veces");
                        Console.WriteLine("-------------------------------------------");
                        break;
           
                    case 2:
                        Console.WriteLine("Escribe una palabra que quieres sustituir");
                        palabra = Console.ReadLine();
                        Console.WriteLine("Escribe la palabra sustituta");
                        string palabraSustituta = Console.ReadLine();
                        expresionRegular = @"\b" + palabra + @"\b";
                        resultado = Regex.Replace(texto, expresionRegular, palabraSustituta );
                        Console.WriteLine(resultado);
                        Console.WriteLine("-------------------------------------------");
                     
                    
                        break;

                    case 3:
                   
                        Console.WriteLine("Escribe una palabra que quieres borrar");
                        palabra = Console.ReadLine();
                        expresionRegular = @"\b" + palabra + @"\b";
                        resultado = Regex.Replace(texto, expresionRegular, "");
                        Console.WriteLine(resultado);
                        Console.WriteLine("-------------------------------------------");
                     
                        break;
                    case 4:
                        Console.WriteLine("Adios");
                        break;
                    default:
               
                         Console.WriteLine("La opción elegida seleccionado no existe");

                        break;
                }

            } while (opcion != 4);
        }
    }
}