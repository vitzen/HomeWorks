//Задание с сайта https://pas1.ru/taskcycle
//Написать программу, подсчитывающую количество четных и нечетных цифр в массиве.
// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)

using System;

namespace homework5._8d
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
            static (double, double) CalculateMethod(double[] newArray)
            {
                double[] evenOddArray = newArray;
                double evenCounter = 0;
                double oddCounter = 0;
                for (int i = 0; i < evenOddArray.Length; i++)
                {
                    if (evenOddArray[i] > 0 && (evenOddArray[i] % 2 == 0))
                    {
                        evenCounter++;
                    }
                    else if ((evenOddArray[i] > 0 && (evenOddArray[i] % 2 == 1)))

                    {
                        oddCounter++;
                    }
                }

                return (evenCounter, oddCounter);
            }


            /// Метод для вывода решения
            static void PrintResultMethod(double even, double odd)
            {
                Console.WriteLine($"Количество Четных чисел вашего массива: {even}");
                Console.WriteLine($"Количество Нечетных чисел вашего массива: {odd}");
            }


            //Блок ввода количества элементов массива
            Console.WriteLine("Программа, подсчитывающая количество четных и нечетных цифр в массиве\n" +
                              "Введите количество чисел для работы программы");
            string inputConsoleNumber = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputConsoleNumber);

            double[] myArray = new double[consoleInput];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputNumberFromConsole = Console.ReadLine();
                int number = InputArrayElementsMethod(inputNumberFromConsole);
                myArray[i] = number;
            }

            (double even, double odd) = CalculateMethod(myArray);
            PrintResultMethod(even, odd);

            // Delay
            Console.ReadKey();
        }
    }
}