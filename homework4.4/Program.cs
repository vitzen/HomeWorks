// Домашнее задание
// 4. В заданном одномерном массиве, состоящем из n целых чисел, подсчитать количество четных элементов.

using System;

namespace homework4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            bool num = Int32.TryParse(inputNumber, out int ArrayCountNumber);

            if (num)
            {
                int[] myArray = new int[ArrayCountNumber];
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива");
                    string element = Console.ReadLine();
                    bool arrayElement = Int32.TryParse(element, out int number);
                    if (arrayElement)
                    {
                        myArray[i] = number;
                    }
                    else
                    {
                        Console.WriteLine("Введите корректное число");
                    }
                }

                Console.WriteLine(myArray);
            }


            else
            {
                Console.WriteLine("Введите верное число");
            }

            // Delay
            Console.ReadKey();
        }
    }
}