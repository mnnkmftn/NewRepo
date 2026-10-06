using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number/100)==0)
            {
                Console.WriteLine("Введено не трехзначное число, введите трехзначное.");
            }
            else if ((number / 100) > 10)
            {
                Console.WriteLine("Введено не трехзначное число, введите трехзначное.");
            }
            else
            {
                int new_number = (number / 100) * 100 + ((number % 100) % 10) * 10 + (number % 100) / 10;
                Console.WriteLine($"Новое число: {new_number}");
            }
        }
    }
}
