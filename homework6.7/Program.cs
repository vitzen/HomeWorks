// Домашнее задание (Перенести все методы в отдельный класс)
// Домашнее задание Подсчет суммы четных эементов массива

using System;

namespace homework6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();


            Console.WriteLine("Программа для подсчета суммы четных эементов массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputNumber = Console.ReadLine();
            int consoleInput = myMethodsClass.InputArrayCountMethod(inputNumber);

            int[] array = new int[consoleInput];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                string inputNumberFromConsole = Console.ReadLine();
                int element = myMethodsClass.InputArrayElementsMethod(inputNumberFromConsole);

                array[i] = element;
            }

            int result = myMethodsClass.CalculateMethod(array);
            myMethodsClass.PrintResultMethod(array, result);


            // Delay
            Console.ReadKey();
        }
    }
}