//Задание с сайта https://pas1.ru/taskcycle
//Используя 2 цикла вывести таблицу умножения
// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)

using System;

namespace homework4._9d
{
    class Program
    {
        /// Метод для решения арифметических задач
        static void CalculateMethod()
        {
            int[,] myArray = new int [10, 10]; //Заполняем массив числами от 0 до 9
            int number;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    myArray[i, j] = i * j;
                    number = i * j;
                    PrintResultMethod(myArray, number);
                    //Console.Write($"{myArray[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        /// Метод для вывода решения
        static void PrintResultMethod(int[,] newArray, int num)
        {
            //Console.Write($"{newArray}\t");
            Console.Write($"{string.Join(" ", num)}\t");
        }


        static void Main(string[] args)
        {
            //Программа
            Console.WriteLine("Таблица умножения полученная с помощью двухмерного массива");
            CalculateMethod();


            // Delay
            Console.ReadKey();
        }
    }
}