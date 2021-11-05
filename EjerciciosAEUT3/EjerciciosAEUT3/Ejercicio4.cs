using System;
using System.Collections.Generic;

namespace EjerciciosAEUT3
{
    public class Ejercicio4
    {
        public void predicciones()
        {

            GestorFichero gf = new GestorFichero();
            List<Prediccion> listadoPredicciones = gf.leerFichero();
            Console.WriteLine("Listado de predicciones");
            double media = 0.0;
           

            for (int i = 0; i < listadoPredicciones[0].Temperature.Count; i++)
            {
                media = media + listadoPredicciones[0].Temperature[i];
            }
            media = media / listadoPredicciones[0].Temperature.Count;
            Console.WriteLine("La temperatura media de las maximas es {0:N2}", media);

            for (int i = 0; i < listadoPredicciones[1].Temperature.Count; i++)
            {
                media = media + listadoPredicciones[1].Temperature[i];
            }
            media = media / listadoPredicciones[1].Temperature.Count;
            Console.WriteLine("La temperatura media de las minimas es {0:N2}", media);

            for (int i = 0; i < listadoPredicciones[2].Temperature.Count; i++)
            {
                media = media + listadoPredicciones[2].Temperature[i];
            }
            media = media / listadoPredicciones[2].Temperature.Count;
            Console.WriteLine("La temperatura media de las medias  es {0:N2}", media);
        }
    }
}