using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Введите внешний диаметр кольца в см:");
            double D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите внутренний диаметр кольца в см:");
            double d = Convert.ToDouble(Console.ReadLine());
            if (D >= 0 && d >= 0)
            {
                double square = (pi / 4) * (D * D - d * d);
                Console.WriteLine($"Диаметр кольца {square} см^2");
            }
            else
            {
                Console.WriteLine("Диаметры были введены некорректно, попробуйте еще раз.");
            }

            Console.WriteLine("Введите номер члена последовательности Фибоначчи");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }
    }
}
