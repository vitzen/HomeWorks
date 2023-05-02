//Задание с сайта https://pas1.ru/taskcycle
//Определить количество простых чисел
// Домашнее задание (Перенести все методы в отдельный класс)

using System;

namespace homework6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine("Программа для подсчета количества простых чисел \n");

            int consoleInput = MyMethodsClass.InputArrayCountMethod();

            int[] array = MyMethodsClass.InputArrayElementsMethod(consoleInput);

            (var countOfEasyNumbers, int[] newArray) = MyMethodsClass.CalculateMethod(array, consoleInput);
            MyMethodsClass.PrintResultMethod(countOfEasyNumbers, newArray);


            // Delay
            Console.ReadKey();
        }
    }
}