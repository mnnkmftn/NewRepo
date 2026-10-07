using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
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
        static double Func(double x) => Math.Sqrt((1 + Math.Cos(x)) / (1 + x * x));    
    }
}
