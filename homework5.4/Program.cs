// Домашнее задание Подсчет суммы четных эементов массива
// (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)

using System;

namespace homework5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Метод парсинга размера массива
            static int InputArrayCountMethod(string inputFromConsole)
            {
                bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);
                if (!consoleInput)
                {
                    Console.WriteLine($"Введите корректное значение");
                }

                return arrayElementsCount;
            }

            /// Метод парсинга вводимых значений эелемнтов массива
            static int InputArrayElementsMethod(string number)
            {
                bool numberInput = Int32.TryParse(number, out int num);
                if (!numberInput)
                {
                    Console.WriteLine($"Введите корректное значение");
                }

                return num;
            }

            /// Метод для решения арифметических задач
            static int CalculateMethod(int[] newArray)
            {
                int sum = 0;
                for (int j = 0; j < newArray.Length; j++)
                {
                    if (newArray[j] % 2 == 0)
                    {
                        sum += newArray[j];
                    }
                }

                return sum;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] newArray, int finishResult)
            {
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
                Console.WriteLine($"Сумма четных лементов массива равна = {finishResult} ");
            }


            Console.WriteLine("Программа для подсчета суммы четных эементов массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputNumber = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputNumber);

            int[] array = new int[consoleInput];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                string inputNumberFromConsole = Console.ReadLine();
                int element = InputArrayElementsMethod(inputNumberFromConsole);

                array[i] = element;
            }

            int result = CalculateMethod(array);
            PrintResultMethod(array, result);


            // Delay
            Console.ReadKey();
        }
    }
}
