// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

using System;

namespace homework4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод с консоли
            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayCount);

            if (consoleInput)
            {
                int[] myArray = new int[arrayCount];
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите число");
                    string number = Console.ReadLine();
                    bool numberInput = Int32.TryParse(number, out int num);
                    if (numberInput)
                    {
                        myArray[i] = myArray[num];
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число элементов в вашем массиве");
            }


            // Delay
            Console.ReadKey();
        }
    }
}