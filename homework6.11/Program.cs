//Задание с сайта https://pas1.ru/taskcycle
//Написать программу, подсчитывающую количество четных и нечетных чисел в массиве.
// Домашнее задание (Перенести все методы в отдельный класс)

using System;

namespace homework6._11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();

            Console.WriteLine("Программа, подсчитывающая количество четных и нечетных цифр в массиве\n");

            int consoleInput = MyMethodsClass.InputArrayCountMethod();

            int[] array = MyMethodsClass.InputArrayElementsMethod(consoleInput);

            (int even, int odd) = MyMethodsClass.CalculateMethod(array);
            MyMethodsClass.PrintResultMethod(even, odd);

            // Delay
            Console.ReadKey();
        }
    }
}