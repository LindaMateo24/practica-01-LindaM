using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int numerador1 = 0;
            int numerador2 = 0;
            int denominador1 = 0;
            int denominador2 = 0;
            string result = "";

            do
            {
                Console.Write(" numerador 1: ");
                numerador1 = int.Parse(Console.ReadLine());


                if (numerador1 < 0)
                {
                    Console.Write("\nError: Número negativon");
                }

            } while (numerador1 < 0);

            do
            {
                Console.Write(" denominador 1:");
                denominador1 = int.Parse(Console.ReadLine());


                if (denominador1 < 0)
                {
                    Console.Write("\nError: Número negativo\n");
                }

            } while (denominador1 < 0);

            do
            {
                Console.Write("numerador 2: ");
                numerador2 = int.Parse(Console.ReadLine());


                if (numerador2 < 0)
                {
                    Console.Write("\nError: Número negativo...\n");
                }

            } while (numerador2 < 0);

            do
            {
                Console.Write("denominador 3:");
                denominador2 = int.Parse(Console.ReadLine());


                if (denominador2 < 0)
                {
                    Console.Write("\nError: Número negativo.\n");
                }

            } while (denominador2 < 0);


            Console.Write("OPERACIONES CON FRACCIONES");
            Console.Write("\n1 - Suma");
            Console.Write("\n2 - Resta");
            Console.Write("\n3 - Multiplicación");
            Console.Write("\n4 - Division\n");

            do
            {

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) { }
               
                
                    /*Caso 1:*/

                        if (denominador1 == denominador2)
                {
                    result = $"{numerador1 + numerador2}/{denominador2}";
                }
                else
                {
                    result = $"{((numerador1 * denominador2) + (numerador2 * denominador1))}/{denominador2 * denominador1}";
                }

                break;

                /*Caso 2:*/

                if (denominador1 == denominador2)
                {
                    result = $"{numerador1 - numerador2}/{denominador2}";
                }
                else
                {
                    result = $"{((numerador1 * denominador2) - (numerador2 * denominador1))}/{denominador2 * denominador1}";
                }

                break;

                /*Caso 3:*/

                result = $"{numerador1 * numerador2}/{denominador2 * denominador1}";

                break;

                /*Caso 4:*/
                {
                    result = $"{(numerador1 * denominador2)}/{(numerador2 * denominador1)}";
                break;

            }

                if (opcion < 1 || opcion > 6)
            {
                Console.Write("\nError: No existe esa opción...\n");
            }
            else
            {
                Console.Write($"\nResultado: {result}");
            }

        } while (opcion< 1 || opcion> 6);

            Console.ReadKey();
        }
    }
}
