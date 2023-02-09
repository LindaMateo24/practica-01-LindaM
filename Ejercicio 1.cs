using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
{
            {
                int Desde;
                int Hasta;
                List<int> lista = new List<int>();
                Console.WriteLine("Fibonacci de un número entero positivo\n");
                do
                {
                    Console.Write("Por favor Digite un número entero positivo desde: ");
                    Desde = int.Parse(Console.ReadLine());


                    if (Desde < 0)
                    {
                        Console.Write("\nError:número negativo...\n");
                    }

                } while (Desde < 0);

                do
                {
                    Console.Write("Por favor Digite un número entero positivo asta: ");
                    Hasta = int.Parse(Console.ReadLine());


                    if (Hasta < 0)
                    {
                        Console.Write("\nError:número negativo...\n");
                    }

                } while (Hasta < 0);

                lista.Add(Desde);

                for (int i = 0; lista.Last() <= Hasta; i++)
                {
                    if (lista.Count() == 1)
                    {
                        lista.Add(1);
                    }
                    else
                    {
                        lista.Add(lista.Last() + lista[i - 1]);
                    }


                    Console.Write($"{lista[i]}, ");
                }


                Console.ReadKey();
            }
        }
    }
}
    }
