//Задание с сайта https://pas1.ru/taskcycle
//Вывести на экран ряд чисел Фибоначчи, состоящий из N элементов. Значение N вводится с клавиатуры.
// Домашнее задание (Перенести все методы в отдельный класс)

using System;

namespace homework6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();

            Console.WriteLine("Программа для вывода на экран ряда чисел Фибоначчи, состоящего из N элементов\n");

            int consoleInput = MyMethodsClass.InputArrayCountMethod();

            int[] fibonacchiArray = MyMethodsClass.CalculateMethod(consoleInput);

            MyMethodsClass.PrintResultMethod(fibonacchiArray);


            // Delay
            Console.ReadKey();
        }
    }
}