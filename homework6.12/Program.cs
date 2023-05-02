//Задание с сайта https://pas1.ru/taskcycle
//Используя 2 цикла вывести таблицу умножения
// Домашнее задание (Перенести все методы в отдельный класс)

using System;

namespace homework6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine("Таблица умножения полученная с помощью двухмерного массива");
            MyMethodsClass.CalculateMethod();


            // Delay
            Console.ReadKey();
        }
    }
}