using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите внешний диаметр кольца в см:");
            double D = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите внутренний диаметр кольца в см:");
            double d = Convert.ToDouble(Console.ReadLine());

            if (d<0 | D<0 | d>D )
            {
                Console.WriteLine("Данные введены некорректно, попробуйте еще раз");
            }
            else
            {
                double square = Math.PI / 4 * (D * D - d * d);
                Console.WriteLine($"Площадь кольца равна {square} см^2");
            }
        }
    }
}
