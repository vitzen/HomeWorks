//Задание с сайта https://pas1.ru/taskcycle
//Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.
// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)

using System;

namespace homework5._7d
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

            static int[] CalculateMethod(int countOfArray)
            {
                int[] fibonachyArray = new int[countOfArray];

                for (int i = 0; i < fibonachyArray.Length; i++)
                {
                    if (i == 0)
                    {
                        fibonachyArray[i] = 0;
                    }
                    else if (i == 1)

                    {
                        fibonachyArray[i] = 1;
                    }
                    else
                    {
                        fibonachyArray[i] = fibonachyArray[i - 1] + fibonachyArray[i - 2];
                    }
                }

                return fibonachyArray;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] newArray)
            {
                Console.WriteLine($"Ряд чисел Фибоначчи начиная с нуля --> {String.Join(" | ", newArray)}");
            }


            // Программа
            Console.WriteLine("Программа для вывода на экран ряда чисел Фибоначчи, состоящего из N элементов\n" +
                              "Ввести общее количество элементов/чисел Фибоначчи");
            string inputFromConsole = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputFromConsole);
            int[] fibonacchiArray = CalculateMethod(consoleInput);
            PrintResultMethod(fibonacchiArray);


            // Delay
            Console.ReadKey();
        }
    }
}