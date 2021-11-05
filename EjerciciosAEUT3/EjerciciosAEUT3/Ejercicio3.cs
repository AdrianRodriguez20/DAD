using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjerciciosAEUT3
{
    public class Ejercicio3
    {
        public void appBinformatica()
        {
            char letra;
            Dictionary<char, int> listaLetras =  new Dictionary<char, int>();
            Console.WriteLine("Inserte Letras: ");
            String cadena="";
            do
            {
                
                letra =( Console.ReadKey().KeyChar).ToString().ToUpper()[0];
                 if (Regex.IsMatch(letra.ToString().ToUpper(), "[A||C||G||T]"))
                {
                    if (!listaLetras.ContainsKey(letra))
                    {
                        listaLetras.Add(letra, 1);

                    }
                    else
                    {
                        listaLetras[letra] += 1;
                    }

                    cadena += letra;
                }
               

            } while (letra != 'F');
            Console.WriteLine("\n");
            
            string[] subs = Regex.Matches(cadena.Remove(cadena.Length - 1), @".{3}").Cast<Match>().Select(m => m.Value).ToArray();
            Dictionary<string, int> listaCodones =  new Dictionary<string, int>();
            for (int i = 0; i < subs.Length; i++)
            {
                if (!listaCodones.ContainsKey(subs[i]))
                {
                    listaCodones.Add(subs[i], 1);

                }
                else
                {
                    listaCodones[subs[i]] += 1;
                }
            }
            listaLetras.Remove('F');
            
            var maxLetra = listaLetras.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            var maxCodon = listaCodones.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            
            Console.WriteLine("Lista de letras: ");
            foreach (var item in listaLetras)
            {
                Console.Write("{0} {1}  ", item.Value, item.Key);
            }

            Console.WriteLine("\n");
            Console.WriteLine("el codón que predomina es " + maxCodon);
            Console.WriteLine("La base que más veces seguidas se repite es la " + maxLetra+ " con "+ listaLetras.Values.Max()+" repeticiones seguidas.");
            
        }







    }
}