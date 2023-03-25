// Домашнее задание
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;

namespace homework4._5
{
    class Program
    {
        static void Main()
        {
            //Блок ввода количества элементов массива
            Console.WriteLine("Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            bool num = Int32.TryParse(inputNumber, out int array_CounterNumber);


            //Блок инициализаторов массивов
            int[] myArray = new int[array_CounterNumber];
            int[] newArray = new int[array_CounterNumber];
            

            if (num)
            {
                //Блок ввода элементов массива
                for (int i = 0; i < array_CounterNumber; i++)
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
                //Блок вывода элементов получившегося массива
                Console.WriteLine($"Элементы вашего массива: {String.Join(" | ", myArray)}");
                
                int indexOfNewArray = 0;
                for (int j= 0; j < newArray.Length; j++)
                {
                    int currentNumber = newArray[j];
                    if (currentNumber > 0)
                    {
                        newArray[indexOfNewArray++] = currentNumber;
                    }
                }
                //Блок вывода элементов получившегося массива
                Console.WriteLine($"Элементы нового массива: {String.Join(" | ", newArray)}");

                
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