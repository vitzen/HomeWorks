// Домашнее задание
//2. Задан массив А, состоящий из n чисел. Найти среднее арифметическое его элементов. Элементы вводятся с клавиатуры.

using System;

namespace homework4._2
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
                    $"Элементы вашего массива: {string.Join(" ", myArray)}"); //Выводим на консоль элементы массива
                double
                    result = (myArray.Sum() / arrayElementsCount); //Подсчет среднего-арифметического значения среди элементов массива
                Console.WriteLine($"Среднее арифметическое значение всех элументов нащего массива = {result}");
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