﻿//Домашнее заданий 6.2
//Написать метод, который бы вернул кортеж данных
//Написать программу, подсчитывающую количество четных и нечетных чисел в массиве.


using System;

namespace homework6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            //Блок ввода количества элементов массива
            Console.WriteLine("Программа, подсчитывающая количество четных и нечетных цифр в массиве\n" +
                              "Введите количество чисел для работы программы");
            string inputConsoleNumber = Console.ReadLine();
            int consoleInput = myMethodsClass.InputArrayCountMethod(inputConsoleNumber);

            double[] myArray = new double[consoleInput];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputNumberFromConsole = Console.ReadLine();
                int number = myMethodsClass.InputArrayElementsMethod(inputNumberFromConsole);
                myArray[i] = number;
            }

            (double even, double odd) = myMethodsClass.CalculateMethod(myArray);
            myMethodsClass.PrintResultMethod(even, odd);

            // Delay
            Console.ReadKey();
        }
    }
}