using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio11
    {
        public void manejoFichero()
        {
            int opcion;
            do
            {
                Console.WriteLine("1. Mostrar el archivo.");
                Console.WriteLine("2. Añadir un texto al final del archivo.");
                Console.WriteLine("3. Borrar una palabra.");
                Console.WriteLine("4. Guardar el archivo con el mismo nombre.");
                Console.WriteLine("5. Salir");
                Console.Write("Inserte la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce el path: ");
                        string path = Console.ReadLine();
                  
                        try
                        {
                            string line = "";
                            StreamReader sr = new StreamReader(path);
                            line = sr.ReadLine();
                            while (line != null)
                            {
                                Console.WriteLine(line);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Console.ReadLine();

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                        
                        break;

                    case 2:
                        
                        Console.WriteLine("Introduce el path: ");
                        string ruta = Console.ReadLine();
                        Console.WriteLine("Introduce el texto : ");
                        string texto = Console.ReadLine();
                        try
                        {
                            StreamWriter sw = File.AppendText(ruta);
                            sw.WriteLine(texto);
                            sw.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }

                        break;

                    case 3:
                        Console.WriteLine("Introduce el path: ");
                        string direccion = Console.ReadLine();
                        Console.WriteLine("Introduce la palabra que deseas eliminar");
                        string palabra = Console.ReadLine();
                        try
                        {
                            string readText = File.ReadAllText(direccion);
                            readText = Regex.Replace(readText, palabra, string.Empty);
                            Console.WriteLine(readText);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                        
                        break;

                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Hasta la próxima.");

                        break;
                    default:
               
                         Console.WriteLine("La opción elegida seleccionado no existe");

                        break;
                }

            } while (opcion != 5);
        }
    }
}
