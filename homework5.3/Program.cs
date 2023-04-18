// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
// 3. Найти наименьший элемент одномерного массива, состоящего из n элементов. Элементы вводятся с клавиатуры.

using System;

namespace homework5._3
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
                int minNumber = newArray[0];
                for (int i = 1; i < newArray.Length; i++)
                {
                    if (newArray[i] < minNumber)
                    {
                        minNumber = newArray[i];
                    }
                }

                return minNumber;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] newArray, int result)
            {
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
                Console.WriteLine($"Наименьший элемент в массиве равен = {result} ");
            }


            //Воод размерности массива
            Console.WriteLine("Введите размерность (количество элементов) массива");
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

            int result = CalculateMethod(array);
            PrintResultMethod(array, result);

            Console.ReadKey();
        }
    }
}