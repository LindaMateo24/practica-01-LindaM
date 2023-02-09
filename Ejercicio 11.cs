using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Calificación Promedio");
            
            Console.WriteLine("número de calificaciones a procesar:");
            int numberOfGrades = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine("Introduce la calificación " + (i + 1) + ":");
                int grade = int.Parse(Console.ReadLine());
                sum += grade;
            }

            int average = sum / numberOfGrades;

            Console.WriteLine("La calificación promedio es: " + average);

            string literal;
            if (average >= 90 && average <= 100)
            {
                literal = "A";
            }
            else if (average >= 80 && average <= 89)
            {
                literal = "B";
            }
            else if (average >= 70 && average <= 79)
            {
                literal = "C";
            }
            else if (average >= 0 && average <= 69)
            {
                literal = "F";
            }
            else
            {
                literal = "Calificación inválida";
            }

            Console.WriteLine("El literal correspondiente es: " + literal);

            Console.ReadLine();
        }
    }
}
