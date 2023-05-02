// Домашнее задание (Перенести все методы в отдельный класс)
//2. Задан массив А, состоящий из n чисел. Найти среднее арифметическое его элементов. Элементы вводятся с клавиатуры.

using System;
using homework6._5;

namespace homework6._5
{
    class Program
    {
        public static void Main()
        {
            //Воод размерности массива
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine("Программа для нахождения среднего арифметическое элементов одномерного массива \n");

            int inputElementsCount = MyMethodsClass.InputArrayCountMethod();

            int[] array = MyMethodsClass.InputArrayElementsMethod(inputElementsCount);

            double result = MyMethodsClass.CalculateMethod(array, inputElementsCount);

            MyMethodsClass.PrintResultMethod(array, result);

            // Delay
            Console.ReadKey();
        }
    }
}