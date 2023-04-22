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
            // Программа
            Console.WriteLine("Программа для подсчета количества простых чисел \n" +
                              "Введите размер массива:");
            string inputConsoleCounter = Console.ReadLine();
            int consoleInput = myMethodsClass.InputArrayCountMethod(inputConsoleCounter);


            int[] inputArray = new int[consoleInput];

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputConsoleNumber = Console.ReadLine();
                int element = myMethodsClass.InputArrayElementsMethod(inputConsoleNumber);
                inputArray[i] = element;
            }

            (var countOfEasyNumbers, inputArray) = myMethodsClass.CalculateMethod(inputArray, consoleInput);
            myMethodsClass.PrintResultMethod(countOfEasyNumbers, inputArray);


            // Delay
            Console.ReadKey();
        }
    }
}