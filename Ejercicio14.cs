using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ecuaciones Lineales de Primer Grado");
            

            Console.WriteLine("Introduce el valor de a:");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el valor de b:");
            decimal b = decimal.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("La ecuación no es lineal de primer grado");
                Console.ReadLine();
                return;
            }

            decimal x = -b / a;

            Console.WriteLine("La solución de la ecuación es x = " + x);

            Console.ReadLine();
        }
     }
    }

