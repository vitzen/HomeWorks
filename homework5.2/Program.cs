// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
//2. Задан массив А, состоящий из n чисел. Найти среднее арифметическое его элементов. Элементы вводятся с клавиатуры.

using System;

namespace homework5._2
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
            static double CalculateMethod(int[] newArray, int inputElementsCount)
            {
                double result = (double)(newArray.Sum()) / inputElementsCount;
                return result;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] newArray, double result)
            {
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
                Console.WriteLine($"Среднее арифметическое2 всех элементов в массиве равна = {result} ");
            }


            //Воод размерности массива
            Console.WriteLine("Программа для нахождения среднего арифметическое элементов одномерного массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            int inputElementsCount = InputArrayCountMethod(inputFromConsole);

            int[] array = new int[inputElementsCount];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputNumberFromConsole = Console.ReadLine();
                int element = InputArrayElementsMethod(inputNumberFromConsole);
                array[i] = element; //Записываем в массив наши числа
            }

            double result = CalculateMethod(array, inputElementsCount);
            PrintResultMethod(array, result);


            // Delay
            Console.ReadKey();
        }
    }
}