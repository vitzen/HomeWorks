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
            Console.WriteLine("Программа для нахождения среднего арифметическое элементов одномерного массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            int inputElementsCount = myMethodsClass.InputArrayCountMethod(inputFromConsole);

            int[] array = new int[inputElementsCount];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputNumberFromConsole = Console.ReadLine();
                int element = myMethodsClass.InputArrayElementsMethod(inputNumberFromConsole);
                array[i] = element; //Записываем в массив наши числа
            }

            double result = myMethodsClass.CalculateMethod(array, inputElementsCount);
            myMethodsClass.PrintResultMethod(array, result);


            // Delay
            Console.ReadKey();
        }
    }
}
