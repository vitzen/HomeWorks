// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
// 3. Найти наименьший элемент одномерного массива, состоящего из n элементов. Элементы вводятся с клавиатуры.

using System;

namespace homework4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Воод размерности массива
            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);


            //Блок инициализации массива и заполнения массива числами
            if (consoleInput)
            {
                int[] myArray = new int[arrayElementsCount];
                // int minNumber = myArray[0]; // Инициализация новой переменой для блока нахождения min значения в массиве


                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите число");
                    string inputNumberFromConsole = Console.ReadLine();
                    bool number = Int32.TryParse(inputNumberFromConsole, out int numberOfArray);
                    if (number)
                    {
                        myArray[i] = numberOfArray; //Записываем в массив наши числа
                    }
                    else
                    {
                        Console.WriteLine("Некорректно введенное число, пробуйте заново!!!");
                    }
                }

                Console.WriteLine(
                    $"Элементы вашего массива: {string.Join(" | ", myArray)}"); //Выводим на консоль элементы массива

                // Реализация сортировки массива и нахождения наименьшего элемента
                int minNumber = myArray[0];
                for (int i = 1; i < myArray.Length; i++)
                {
                    if (myArray[i] < minNumber)
                    {
                        minNumber = myArray[i];
                    }
                }

                Console.WriteLine($"Минимальный элемент в массиве равен: {minNumber}");
            }
            else
            {
                Console.WriteLine("Некорректно введенное число, Запускаем программу заново");
            }


            // Delay
            Console.ReadKey();
        }
    }
}