// Домашнее задание
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;

namespace homework4._5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            bool num = Int32.TryParse(inputNumber, out int array1_CounterNumber);
            int array2_CounterNumber = 0; // Инициализируем по умолчанию размерность нового массива

            if (num)
            {
                int[] myArray = new int[array1_CounterNumber]; //Инициализация массива 1
                int[] signArray = new int[array2_CounterNumber];

                //Блок ввода элементов массива
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива");
                    string inputElement = Console.ReadLine();
                    bool element = Int32.TryParse(inputElement, out int arrayElement);


                    if (element)
                    {
                        myArray[i] = arrayElement;
                        if (arrayElement >= 0)
                        {
                            array2_CounterNumber++;
                            //signArray[i] = arrayElement;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Введите корректное число в качестве элемента массива");
                    }
                }

                //Блок вывода элементов получившегося массива
                Console.WriteLine($"Элементы вашего массива: {String.Join(" | ", myArray)}");
                //Console.WriteLine($"Элементы нового массива: {String.Join(" | ", signArray)}");

                //Блок инициализации нового массива и операции над элементами массива
                // int[] signArray;
                // signArray = myArray.Where();


                //Console.WriteLine($"Элементы нового массива: {String.Join(" | ", signArray)}");
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