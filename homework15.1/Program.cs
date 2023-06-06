// ЗАДАЧА:
// Создать проект консольной программы с решениями задач:
//     ● Дано целое число K (> 0) и целочисленная последовательность A. Найти теоретико-множественную
// разность двух фрагментов A: первый содержит все четные числа, а второй — все числа с порядковыми
//     номерами, большими K. В полученной последовательности (не содержащей одинаковых элементов)
// поменять порядок элементов на обратный.

using System;
using System.Reflection.Emit;
using System.Text;
using System.Linq;

namespace homework15._1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задача 1");

            int K = 10;
            int countOfList = 50;
            List<int> subsequenceA = new List<int>(countOfList);

            Random random = new Random();
            for (int i = 0; i < countOfList; i++)
            {
                subsequenceA.Add(random.Next(1, 100));
            }

            var subsequenceB = subsequenceA
                .Where(x => x % 2 == 0)
                .ToArray();

            var subsequenceC = subsequenceA
                .Select(x => subsequenceA.GetRange(K + 1, countOfList - K - 1))
                .ToArray();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("* Исходная последовательность A: " +
                              (String.Join(",", subsequenceA)));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("* Последовательность B : " +
                              (String.Join(",", subsequenceB)));

            Console.WriteLine("* Последовательность C : " +
                              (String.Join(",", subsequenceC)));

            //Задержка
            Console.ReadKey();
        }
    }
}