using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosIniciales
{
    class Ejercicio5
    {
        //Lee un número por teclado e indica si es divisible entre 2 (resto = 0).
        //Si no lo es, también debemos indicarlo. En caso afirmativo que calcule
        //el factorial (n * (n-1) * ... * 1)
        public String es_divisible(int num)
        {
            String resultado;
            int factorial=1;
            if (num % 2 == 0)
            {
                for(int i=2; i<=num; i++)
                {
                    factorial = factorial * i;
                }
                resultado = "El número " + num + " es par. Su factorial es " + factorial;
            }
            else 
            {
                resultado = "El número" + num + " es impar.";
            }
            return resultado;
        }

    }
}

