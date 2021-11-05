using System;

namespace EjerciciosAEUT3
{
    public class Ejercicio1B
    {
        public void diasHasta()
        {


            var diaCanarias = new DateTime(2022, 5, 30);
            int dias;
            int opcion;
            do
            {
                Console.WriteLine("1. Cuantos dias quedan desde hoy hasta DDC.");
                Console.WriteLine("2. Cuantos dias quedan hasta DDC (Fecha indicada).");
                Console.WriteLine("5. Salir");
                Console.Write("Inserte la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        dias = (int)(diaCanarias - DateTime.Now).TotalDays;
                        Console.WriteLine("Quedan" + dias + " dias");
                        break;

                    case 2:
                        Console.Write("Introduce el día: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el mes: ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el año: ");
                        int anio = Convert.ToInt32(Console.ReadLine());
                        String dateStr = dia + "/" + mes + "/" + anio;
                        DateTime diaUsuario = DateTime.Parse(dateStr);
                        dias = (int)(diaCanarias - diaUsuario).TotalDays;
                        Console.WriteLine("Quedan" + dias + " dias");
                        break;

                    default:

                        Console.WriteLine("La opción elegida seleccionado no existe");

                        break;
                }

            } while (opcion != 3);
        }
    }
}