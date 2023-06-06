// ЗАДАЧА:
// Создать проект консольной программы с решениями задач:
//     ● Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
//     содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную
// последовательность по возрастанию.

using System;
using System.Reflection.Emit;
using System.Text;
using System.Linq;

namespace homework15._2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задача 2");

            int K1 = 20;
            int K2 = 40;
            int countOfList = 60;
            List<int> subsequenceOne = new List<int>();
            List<int> subsequenceTwo = new List<int>();

            Random random = new Random();
            for (int i = 0; i < countOfList; i++)
            {
                subsequenceOne.Add(random.Next(1, 100));
                subsequenceTwo.Add(random.Next(1, 100));
            }

            Console.WriteLine("* Исходная последовательность One : " +
                              (String.Join(",", subsequenceOne)));
            Console.WriteLine("* Исходная последовательность Two : " +
                              (String.Join(",", subsequenceTwo)));

            var newSubSequenceOne = subsequenceOne
                .Where(x => x > K1)
                .ToList();

            var newSubSequenceTwo = subsequenceTwo
                .Where(x => x < K2)
                .ToList();

            var resultSubSequence = newSubSequenceOne
                .Concat(newSubSequenceTwo)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine("* Новая последовательность One : " +
                              (String.Join(",", newSubSequenceOne)));
            Console.WriteLine("* Новая последовательность Two : " +
                              (String.Join(",", newSubSequenceTwo)));
            Console.WriteLine("* Результат склейки последовательностей и сортировка по возрастанию : " +
                              (String.Join(",", resultSubSequence)));

            //Задержка
            Console.ReadKey();
        }
    }
}