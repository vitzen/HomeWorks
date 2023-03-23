// Домашнее задание
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;

namespace homework4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            bool num = Int32.TryParse(inputNumber, out int arrayNumber);


            if (num)
            {
                int[] myArray = new int[arrayNumber]; //Инициализация массива

                //Блок ввода элементов массива
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива");
                    string inputElement = Console.ReadLine();
                    bool element = Int32.TryParse(inputElement, out int arrayElement);
                    if (element)
                    {
                        myArray[i] = arrayElement;
                    }
                    else
                    {
                        Console.WriteLine("Введите корректное число в качестве элемента массива");
                    }
                }
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