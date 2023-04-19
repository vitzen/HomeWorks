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
            
            
            
           
            
            // Блок ввода размерности массива
            Console.WriteLine("Программа для подсчета количества простых чисел \n" +
                              "Введите количество чисел для подсчета суммы:");
            string inputConsoleCounter = Console.ReadLine();
            bool consoleCounter = Int32.TryParse(inputConsoleCounter, out int inputArrayCounter);
            if (consoleCounter)
            {
                // Блок инициализации массива
                int[] inputArray = new int[inputArrayCounter];
                int sum = 0;

                // Блок ввода элементов массива
                for (int i = 0; i < inputArrayCounter; i++)
                {
                    Console.WriteLine("Введите число");
                    string inputConsoleNumber = Console.ReadLine();
                    bool number = Int32.TryParse(inputConsoleNumber, out int inputNumber);

                    if (number)
                    {
                        inputArray[i] = inputNumber;
                        if ((inputNumber > 0) && (inputNumber / inputNumber == 1) && (inputNumber / 1 == inputNumber))
                        {
                            sum += inputNumber;
                        }
                        else
                        {
                            Console.WriteLine("Простые числа не могут быть отрицательными или равны 0, повторите ввод заново");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите корректное число для работы программы");
                    }
                }

                Console.WriteLine($"Введенные вами числа для подсчета : {String.Join(" | ", inputArray)}");
                Console.WriteLine($"Сумма простых чисел равна : {sum}");
            }

            else
            {
                Console.WriteLine("Введите корректное число");
            }


            // Delay
            Console.ReadKey();
        }
    }
}