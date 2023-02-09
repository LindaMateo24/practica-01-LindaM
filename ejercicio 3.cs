using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Volumen  de las figuras geometricas cubo, esfera, cono y piramide");

          
            int opcion;
            double dato1;
            double dato2;

            Console.WriteLine("\n Seleccione la figura a la cual quiere conocer el volumen: \n");
            Console.WriteLine("Cubo");
            Console.WriteLine("Esfera");
            Console.WriteLine("Cono");
            Console.WriteLine("Pirámide");

            do
            {
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.Write(" Digite la longitud de uno de los lados: ");
                            dato1 = double.Parse(Console.ReadLine());


                            if (dato1 < 0)
                            {
                                Console.Write("\nError: No introducir numeros negativos\n");
                            }

                        } while (dato1 < 0);

                        Console.Write($"\nResultado: {Math.Pow(dato1, 3)}");
                        break;

                    case 2:
                        do
                        {
                            Console.Write("Digite el radio de la Esfera: ");
                            dato1 = double.Parse(Console.ReadLine());


                            if (dato1 < 0)
                            {
                                Console.Write("\nError: No introducir numeros negativos\n");
                            }

                        } while (dato1 < 0);

                        Console.Write($"\nResultado: {4 / 3 * Math.PI * (Math.Pow(dato1, 3))}");
                        break;

                    case 3:
                        do
                        {
                            Console.Write("Digite la radio del Cono: ");
                            dato1 = double.Parse(Console.ReadLine());


                            if (dato1 < 0)
                            {
                                Console.Write("\nError: No introducir numeros negativos\n");
                            }

                        } while (dato1 < 0);

                        do
                        {
                            Console.Write("Digite la altura del Cono: ");
                            dato2 = double.Parse(Console.ReadLine());


                            if (dato2 < 0)
                            {
                                Console.Write("\nError: No introducir numeros negativos\n");
                            }

                        } while (dato2 < 0);

                        Console.Write($"\nResultado: {(Math.PI * Math.Pow(dato1, 2) * dato2) / 3}");
                        break;

                    case 4:
                        do
                        {
                            Console.Write("Digite  la altura de la Piramide: ");
                            dato1 = double.Parse(Console.ReadLine());


                            if (dato1 < 0)
                            {
                                Console.Write("\nError: No introducir numeros negativos\n");
                            }

                        } while (dato1 < 0);

                        do
                        {
                            Console.Write("Digite la longitud de uno de los lado de la Piramide: ");
                            dato2 = double.Parse(Console.ReadLine());


                            if (dato2 < 0)
                            {
                                Console.Write("\nError: No introducir numeros negativos\n");
                            }

                        } while (dato2 < 0);

                        Console.Write($"\nResultado: {(dato1 * dato2 * dato2) / 3}");
                        break;
                }

                if (opcion < 1 || opcion > 4)
                {
                    Console.Write("\n ESTA OPCION NO EXISTE\n");
                }

            } while (opcion < 1 || opcion > 4);

            Console.ReadKey();
        }
    }
}
