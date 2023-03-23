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


            //Блок инициализации массива и заполнения его элементами
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

                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", myArray)}");
                //Блок подсчета суммы четных эементов массива
                int sum = 0;
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[j] % 2 == 0)
                    {
                        sum += myArray[j];
                    }
                }

                Console.WriteLine($"Сумма четных элементов массива равна: {sum}");
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