//Задание с сайта https://pas1.ru/taskcycle
//Определить количество простых чисел
// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)

using System;

namespace homework5._6d
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
            static (int, int[]) CalculateMethod(int[] newArray, int myCount)
            {
                //var myArray = newArray;
                int countOfEasyNumbers = myCount;


                for (int i = 0; i < newArray.Length; i++)
                {
                    if (newArray[i] == 0 || newArray[i] == 1)
                    {
                        countOfEasyNumbers--;
                    }

                    else if (newArray[i] > 1)
                    {
                        for (int j = 2; j < newArray[i]; j++)
                        {
                            if (newArray[i] % j == 0)
                            {
                                countOfEasyNumbers--;
                                break;
                            }
                        }
                    }
                }

                return (countOfEasyNumbers, newArray);
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int counter, int[] ourArray)
            {
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", ourArray)}");
                Console.WriteLine($"Количество простых чисел в массиве = {counter} ");
            }


            // Программа
            Console.WriteLine("Программа для подсчета количества простых чисел \n" +
                              "Введите размер массива:");
            string inputConsoleCounter = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputConsoleCounter);


            int[] inputArray = new int[consoleInput];

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputConsoleNumber = Console.ReadLine();
                int element = InputArrayElementsMethod(inputConsoleNumber);
                inputArray[i] = element;
            }

            (var countOfEasyNumbers, inputArray) = CalculateMethod(inputArray, consoleInput);
            PrintResultMethod(countOfEasyNumbers, inputArray);


            // Delay
            Console.ReadKey();
        }
    }
}