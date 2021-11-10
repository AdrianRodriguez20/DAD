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

            Console.WriteLine("La temperatura media de las maximas es {0:N2}", listadoPredicciones[0].tempertaturaMedia());
            Console.WriteLine("La temperatura más frecuente de las maximas es {0:N2}", listadoPredicciones[0].temperaturaMasFrecuente());
            
            Console.WriteLine("La temperatura media de las minimas es {0:N2}",  listadoPredicciones[1].tempertaturaMedia());
            Console.WriteLine("La temperatura más frecuente de las minimas es {0:N2}", listadoPredicciones[1].temperaturaMasFrecuente());
            
            Console.WriteLine("La temperatura media de las medias  es {0:N2}",  listadoPredicciones[2].tempertaturaMedia());
            Console.WriteLine("La temperatura más frecuente de las medias es {0:N2}", listadoPredicciones[2].temperaturaMasFrecuente());
            
            
        }
    }
}