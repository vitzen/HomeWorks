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

            //Последовательность четных чисел
            var subsequenceB = subsequenceA
                .Where(x => x % 2 == 0)
                .ToArray();

            //Последовательность из чисел начиная с 11-ого порядкового номера
            var subsequenceC = subsequenceA
                .Where((x, i) => { return i > K; })
                .ToArray();

            //Разность двух полученных множеств, удаление повторяющихся элементов,
            //реверс чисел в последовательности
            var subSequenceD = subsequenceB
                .Except(subsequenceC)
                .Distinct()
                .Reverse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("* Исходная последовательность A: " +
                              (String.Join(",", subsequenceA)));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("* Последовательность B : " +
                              (String.Join(",", subsequenceB)));

            Console.WriteLine("* Последовательность C : " +
                              (String.Join(",", subsequenceC)));

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("* Итоговое множество : " +
                              (String.Join(",", subSequenceD)));

            //Задержка
            Console.ReadKey();
        }
    }
}