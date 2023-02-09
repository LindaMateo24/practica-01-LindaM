using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejeercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioNeto, salarioBruto, afp, ars, horas, extra, precio;

            do
            {
                Console.Write("Ingrese las horas trabajadas: ");
                horas = double.Parse(Console.ReadLine());

                if (horas <= 0)
                {
                    Console.Write("Las horas tienen que ser mayores que 0\n");
                }

            } while (horas <= 0);


            do
            {
                Console.Write("Ingrese precio de las horas: ");
                precio = double.Parse(Console.ReadLine());


                if (precio <= 0)
                {
                    Console.Write("El precio tienen que ser mayores que 0\n");
                }

            } while (precio <= 0);


            if (horas > 44)
            {
                salarioBruto = precio * 44;
                salarioBruto = +precio * 0.3 * (44 - horas);
            }
            else
            {
                salarioBruto = precio * horas;
            }

            afp = 0.0304 * salarioBruto;
            ars = 0.0287 * salarioBruto;

            salarioNeto = salarioBruto - (afp + ars);

            Console.WriteLine("Su salario Bruto es de: " + salarioBruto);
            Console.WriteLine("Su salario neto  es de: " + salarioNeto);

            Console.ReadKey();
        }
    }
}
