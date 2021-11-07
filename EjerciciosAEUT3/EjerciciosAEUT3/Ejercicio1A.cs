using System;

namespace EjerciciosAEUT3
{
    public class Ejercicio1A
    {
        public void diasHasta()
        {

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

                      Console.Write( "Quedan  " + diasHasta(DateTime.Now ) +" para el próximo día de canarias.");
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

                      DateTime   fechaUsuario = new DateTime(anio, mes, dia);
                      Console.WriteLine( "Quedan  " + diasHasta(fechaUsuario ) +" para el próximo día de canarias.");
                      
                      break;

                  default:

                      Console.WriteLine("La opción elegida seleccionado no existe");

                      break;
              }

          } while (opcion != 3);
          
          
          

        }
        
        /**
         * Método para calcular los años bisiestos
         */
        static int anioBisiesto(DateTime fecha)
        {
            int anios =fecha.Year;

            if (fecha.Month <= 2)
            {
                anios--;
            }

            return anios / 4 - anios / 100 + anios / 400;
        }
        /**
         * Método para calcular los dias hasta el dia de canarias
         */
        static int diasHasta(DateTime fechaUsuario )
        {
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            DateTime   diaCanarias = new DateTime(fechaUsuario.Year+1, 5, 30);
 
    
            int diasU = fechaUsuario.Year * 365 + fechaUsuario.Day;
 
 
            for (int i = 0; i < fechaUsuario.Month - 1; i++)
            {
                diasU += dias[i];
            }
 

            diasU += anioBisiesto(fechaUsuario);
 
         
            int diasC = diaCanarias.Year * 365 + diaCanarias.Day;
            for (int i = 0; i < diaCanarias.Month - 1; i++)
            {
                diasC += dias[i];
            }
            diasC += anioBisiesto(diaCanarias);
 
      
            return (diasC - diasU);
        }
    }
    
}