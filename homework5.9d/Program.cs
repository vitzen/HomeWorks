//Задание с сайта https://pas1.ru/taskcycle
//Используя 2 цикла вывести таблицу умножения
// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
using System;

namespace homework4._9d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myarray = new int [10, 10]; //Заполняем массив числами от 0 до 9

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    myarray[i, j] = i * j;
                    Console.Write($"{myarray[i, j]}\t");
                }

                Console.WriteLine();
            }


            // Delay
            Console.ReadKey();
        }
    }
}