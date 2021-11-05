using System;

namespace EjerciciosAEUT3
{
    public class Ejercicio1A
    {
        public void diasHasta()
        {
      
            Console.WriteLine("Introduce el día");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el año");
            int anio = Convert.ToInt32(Console.ReadLine());
          
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int diaCanarias = 30;
            int mesCanarias = 5;
            int anioCanarias = 2022;

            int diasHasta = dias[mes - 1] - dia;
          
            for (int i = mes; i < dias.Length; i++)
            {
              diasHasta+=dias[i];  
            }

            for (int i = 0; i <= mesCanarias-1; i++)
            {
                diasHasta+=dias[i];
            }

            diasHasta = diasHasta - (dias[mesCanarias-1]-diaCanarias);
            Console.WriteLine("Quedan " + diasHasta +" Para la fecha.");
          
        }
    }
}