using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число х:");
            var x = double.Parse(Console.ReadLine());

            var y = Func(x);
            Console.WriteLine($"Результат вычисления f(x)={y}");
        }
        static double Func(double x) => 1 + Math.Sqrt((x * x - 1) / (x * x + 1));
    }
}
