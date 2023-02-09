using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador Física");

            Console.WriteLine(" calcular tiempo, velocidad y distancia ");
            Console.WriteLine("");
            Console.WriteLine("Menú");
            Console.WriteLine("1. Tiempo");
            Console.WriteLine("2. Velocidad");
            Console.WriteLine("3. Distancia");
           

            Console.WriteLine("Seleccionae una opción:");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine(" primer valor:");
            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor:");
            double value2 = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double time = value2 / value1;
                    Console.WriteLine("El tiempo es: " + time + " segundos");
                    break;
                case 2:
                    double velocity = value1 / value2;
                    Console.WriteLine("La velocidad es: " + velocity + " m/s");
                    break;
                case 3:
                    double distance = value1 * value2;
                    Console.WriteLine("La distancia es: " + distance + " metros");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.ReadLine();
        }
      }
    }

