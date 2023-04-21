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
            static (int, int[]) CalculateMethod(int[] newArray)
            {
                //var myArray = newArray;
                int countOfEasyNumbers = 0;
                for (int i = 0; i < newArray.Length; i++)
                {
                    for (int j = 1; j < i + 2; j++)
                    {
                        if (i % j == 0 & i % 1 == 0)
                        {
                        }
                    }


                    if ((newArray[i] > 0) && ((newArray[i] / newArray[i] == 1) || (newArray[i] / 1 == newArray[i])))
                        //     Console.Write("Введите конец диапазона от 2 до : ");
                        // int end=int.Parse(Console.ReadLine());
                        // for(int i=2; i<=end; i++) {
                        //     bool b=true;
                        //     for(int j=2; j<i; j++) {
                        //         if(i%j==0 & i%1==0)
                        // {
                        //             b=false;
                        //  }
                        //     }
                        //     if(b) {
                        //         Console.Write("{0} ", i);


                    {
                        countOfEasyNumbers++;
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

            (var countOfEasyNumbers, inputArray) = CalculateMethod(inputArray);
            PrintResultMethod(countOfEasyNumbers, inputArray);


            // Delay
            Console.ReadKey();
        }
    }
}