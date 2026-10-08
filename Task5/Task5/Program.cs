using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main()
        {
            var z = Calc();
            Console.WriteLine($"Результат вычисления x={z}");
        }
        static double Calc() => Func(2, 3) + Func(3, 5) * Func(5, 7);

        static double Func(int x, int y) => Math.Pow(Math.E, -(Math.Sqrt(x + y * y)));
    }
}
