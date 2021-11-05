using System;

namespace EjerciciosIniciales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("EJERCICIOS INICIALES C #");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Ejercico 1");
                Console.WriteLine("2. Ejercico 2");
                Console.WriteLine("3. Ejercico 3");
                Console.WriteLine("4. Ejercico 4");
                Console.WriteLine("5. Ejercico 5");
                Console.WriteLine("6. Ejercico 6");
                Console.WriteLine("7. Ejercico 7");
                Console.WriteLine("8. Ejercico 8");
                Console.WriteLine("9. Ejercico 9");
                Console.WriteLine("11. Ejercico 11");
                Console.WriteLine("12. Salir");
                Console.WriteLine("--------------------------");
                Console.Write("Inserte la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Ejercicio1 ej1 = new Ejercicio1();
                        ej1.piramideVertical();
                        break;

                    case 2:
                        Console.Write("Inserte dni sin letra: ");
                        int dni = Convert.ToInt32(Console.ReadLine());
                        Ejercicio2 ej2 = new Ejercicio2();
                        Console.WriteLine(ej2.calcular_letra_dni(dni)) ;
                        break;

                    case 3:
                        Console.Write("Introduce tu peso: ");
                        int peso = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce tu altura: ");
                        int altura = Convert.ToInt32(Console.ReadLine());
                        Ejercicio3 ej3 = new Ejercicio3();
                        Console.WriteLine(ej3.calcular_indice_masa_corporal(peso,altura));
                        break;

                    case 4:
                        Console.Write("Introduce primer numero: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el segundo numero: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Ejercicio4 ej4 = new Ejercicio4();
                        Console.WriteLine(ej4.es_mayor(a,b));
                        break;

                    case 5:
                        Console.Write("Introduce un numero: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Ejercicio5 ej5 = new Ejercicio5();
                        Console.WriteLine(ej5.es_divisible(num));
                        break;

                    case 6:
                        Ejercicio6 ej6 = new Ejercicio6();
                        ej6.buscadorNum();
                        break;

                    case 7:
                        Ejercicio7 ej7 = new Ejercicio7();
                        ej7.adivinarNumero();
                        break;

                    case 8:
                        Ejercicio8 ej8 = new Ejercicio8();
                        ej8.calcular();
                        break;

                    case 9:
                        Ejercicio9 ej9 = new Ejercicio9();
                        ej9.randomNum();
                        break;

                    case 11:
                        Ejercicio11 ej11 = new Ejercicio11();
                        ej11.manejoFichero();
                        break;
                    case 12:
                        Console.WriteLine("Adios");
                        Environment.Exit(1);
                        break;
                    default:
               
                            Console.WriteLine("El ejercicio seleccionado no existe");
                  
                        
                        break;
                }


            } while (opcion != 12);
        }
    }
}
