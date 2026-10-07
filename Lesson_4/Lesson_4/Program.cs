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
            var z = Calc();
            Console.WriteLine($"Результат вычисления f(x)={z}");
        }

        //static double Func()=>throw new NotImplementedException();

        static double Calc() => Func(2, 2) + Func(5, 3) + Func(11, 5);
        static double Func(int x,int y) => Math.Sqrt((1 + Math.Sqrt(x)) / y);
    }
}
