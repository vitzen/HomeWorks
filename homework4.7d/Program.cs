//Задание с сайта https://pas1.ru/taskcycle
//Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.

using System;

namespace homework4._7d
{
    class Program
    {
        static void Main(string[] args)
        {
            // Блок ввода чисел
            Console.WriteLine("Ввести общее количество элементов/чисел Фибоначчи");
            string inputFromConsole = Console.ReadLine();
            bool countFromConsole = Int32.TryParse(inputFromConsole, out int consoleNumbers);

            if (countFromConsole)
            {
                int[] fibonachyArray = new int[consoleNumbers];
                //int current = 0;

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

                Console.WriteLine($"Ряд чисел Фибоначчи начиная с нуля --> {String.Join(" | ", fibonachyArray)}");
            }
            else
            {
                Console.WriteLine("Введите корректное число набора чисел");
            }

            // Delay
            Console.ReadKey();
        }
    }
}