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
            bool num = Int32.TryParse(inputNumber, out int myArray_CounterNumber);


            //Блок инициализаторов массивов
            int newArrayCounterNumber = myArray_CounterNumber;
            int[] myArray = new int[myArray_CounterNumber];
            int[] newArray = new int[newArrayCounterNumber];
            

            if (num)
            {
                //Блок ввода элементов массива
                for (int i = 0; i < myArray_CounterNumber; i++)
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
                for (int i= 0; i < newArrayCounterNumber; i++)
                {
                    int currentNumber = myArray[i];
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