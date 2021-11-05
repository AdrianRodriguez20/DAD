using System;
using System.Collections;
using System.Collections.Generic;


namespace EjerciciosAEUT3
{
    class Program
    {

        static void Main(string[] args)
        {

     //      Ejercicio3 ej3 = new Ejercicio3();
     //      ej3.appBinformatica();

      //  Ejercicio1A ej1A = new Ejercicio1A();
      //  ej1A.diasHasta();
    
      GestorFichero gf = new GestorFichero();
      List<Prediccion> listadoPredicciones =gf.leerFichero();
      Console.WriteLine("Listado de predicciones");
      double media = 0.0;
      foreach (Prediccion p in listadoPredicciones)
      {
          for (int i=0; i < p.Temperature.Count; i++) {
              media = media + p.Temperature[i];
          }
          media = media / p.Temperature.Count;
          Console.WriteLine("La temperatura media es {0:N2}", media);
      }

        }







    }
}
