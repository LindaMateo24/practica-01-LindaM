using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine("Realizar programa que resuelva ecuaciones de segundo grado con la formula general. ");

            Console.WriteLine("Valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            if (raizNegativa.ToString() == "NaN" || raizPositiva.ToString() == "NaN")
            {
                Console.WriteLine("la raíz no es real");
            }
            else if (raizPositiva != raizNegativa)
            {
                Console.WriteLine("Negativa -: " + raizNegativa);
                Console.WriteLine("Positiva +: " + raizPositiva);
            }
            else
            {
                Console.WriteLine(("Positiva +: ", raizPositiva);
            }
        }
    }
}
