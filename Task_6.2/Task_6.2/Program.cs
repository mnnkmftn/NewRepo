using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 10. Дано слово «клавиатура», получить слова «тиара» и «рука».
            var word = "клавиатура";

            var result_1 = word.Substring(6, 1) +word.Substring(4,2)+word.Remove(0, 8);
            var result_2 = word.Substring(8, 1) + word.Substring(7, 1) + word.Remove(1, 8);

            Console.WriteLine($"В начале было слово \"{word}\".");
            Console.WriteLine($"Получились слова \"{result_1}\" и \"{result_2}\".");
        }
    }
}
