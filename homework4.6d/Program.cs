//Задание с сайта https://pas1.ru/taskcycle
//Определить количество простых чисел

using System;

namespace homework4._6d
{
    class Program
    {
        static void Main(string[] args)
        {
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