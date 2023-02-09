using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args);
        

    class Program
        {
            static void Main(string[] args)
            {
                int opcion;
                double dato1;
                double dato2;

                Console.Write("Calculo de Area geometricas, POR FAVOR SELECCIONAR UNA OPCION");
                Console.Write("\n1 - Cuadrado");
                Console.Write("\n2 - Circulo");
                Console.Write("\n3 - Triangulo");
                Console.Write("\n4 - Pentágono");
                Console.Write("\n5 - Hexágono\n");

                do
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion);
                
                    /*Caso1*/: 
                        do
                    {
                        Console.Write("Por favor Digite un número entero de la longitud de la cara del cuadrado: ");
                        dato1 = double.Parse(Console.ReadLine());


                        if (dato1 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato1 < 0);

                    Console.Write($"\nResultado: {Math.Pow(dato1, 2)}");
                    

                    /*Caso2 */:
                        do
                    {
                        Console.Write("Por favor Digite el radio de la cirunferencia: ");
                        dato1 = double.Parse(Console.ReadLine());


                        if (dato1 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato1 < 0);

                    Console.Write($"\nResultado: {Math.PI * (Math.Pow(dato1, 2))}");
                    


                    /*Caso3 */:
                        do
                    {
                        Console.Write("Por favor Digite la base del Triangulo: ");
                        dato1 = double.Parse(Console.ReadLine());


                        if (dato1 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato1 < 0);

                    do
                    {
                        Console.Write("Por favor Digite la altura del Triangulo: ");
                        dato2 = double.Parse(Console.ReadLine());


                        if (dato2 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato2 < 0);

                    Console.Write($"\nResultado: {(dato1 * dato2) / 2}");
                    break;

                    /*case 4*/
                    do
                    {
                        Console.Write("Por favor Digite el Perimetro del Pentágono: ");
                        dato1 = double.Parse(Console.ReadLine());


                        if (dato1 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato1 < 0);

                    do
                    {
                        Console.Write("Por favor Digite la apotema del Pentágono: ");
                        dato2 = double.Parse(Console.ReadLine());


                        if (dato2 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato2 < 0);

                    Console.Write($"\nResultado: {dato1 * dato2 * 1 / 2}");
                    break;

                    /*case 5*/

                    do
                    {
                        Console.Write("Por favor Digite la Perimetro del Hexágono: ");
                        dato1 = double.Parse(Console.ReadLine());


                        if (dato1 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato1 < 0);

                    do
                    {
                        Console.Write("Por favor Digite la apotema del Hexágono: ");
                        dato2 = double.Parse(Console.ReadLine());


                        if (dato2 < 0)
                        {
                            Console.Write("\nError: Número negativo...\n");
                        }

                    } while (dato2 < 0);

                    Console.Write($"\nResultado: {(dato1 * dato2) / 2}");
                    break;

                    if (opcion < 1 || opcion > 5)
                    {
                        Console.Write("\nError: No existe esa opción...\n");
                    }

                } while (opcion < 1 || opcion > 5);

                Console.ReadKey();
            }
        }
    } 
}
        