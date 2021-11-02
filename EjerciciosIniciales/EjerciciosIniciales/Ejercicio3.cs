using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio3
    {
        //Programa que nos dice qué índice de masa corporal tenemos a partir de nuestro peso en kilogramos y nuestra altura en metros.

        public Double calcular_indice_masa_corporal(Double peso , Double altura)
        {
            return peso / (altura * altura);

        }
    }
}
