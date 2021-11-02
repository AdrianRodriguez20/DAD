using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio4
    {
        //Declara 2 variables numéricas (con el valor que desees), e indica cuál es más grande de las dos. Si son iguales indicarlo también.
        public String es_mayor(int a , int b)
        {
            String resultado;
            if (a > b)
            {
                resultado = a + " es mayor que " + b;
            }else if (a < b)
            {
                resultado = b + " es mayor que " + a;
            }
            else
            {
                resultado = a + " es igual a " + b;
            }
            return resultado;
        }
    }
}
