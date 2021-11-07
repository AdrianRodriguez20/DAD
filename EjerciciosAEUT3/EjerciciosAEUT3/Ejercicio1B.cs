using System;

namespace EjerciciosAEUT3
{
    public class Ejercicio1B
    {
        public void diasHasta()
        {


            var diaCanarias = new DateTime();
            int dias;
            int opcion;
            do
            {
                Console.WriteLine("1. Cuantos dias quedan desde hoy hasta DDC.");
                Console.WriteLine("2. Cuantos dias quedan hasta DDC (Fecha indicada).");
                Console.WriteLine("3. Salir");
                Console.Write("Inserte la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        diaCanarias = new DateTime(DateTime.Now.Year+1, 5, 30);
                        dias = (int)(diaCanarias - DateTime.Now).TotalDays;
                        Console.WriteLine("Quedan" + dias + " dias");
                        break;

                    case 2:
                        int dia=0;
                        int mes = 0;
                        int anio = 0;
                        bool valido;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Introduce el día");
                                dia = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introduce el mes");
                                mes = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introduce el año");
                                anio = Convert.ToInt32(Console.ReadLine());
                                valido = true;
                            }catch(Exception e)
                            {
                                Console.WriteLine("Error: " + e.Message);
                                valido = false;
                            }
 
                        }while(valido == false);
                     
        
                        diaCanarias = new DateTime(anio+1, 5, 30);

                        DateTime diaUsuario = new DateTime(anio, mes, dia);
                        dias = (int)(diaCanarias - diaUsuario).TotalDays;
                        Console.WriteLine("Quedan "  + dias + " dias");
                        break;

                    default:

                        Console.WriteLine("La opción elegida seleccionado no existe");

                        break;
                }

            } while (opcion != 3);
        }
    }
}