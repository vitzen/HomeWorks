// Домашнее задание (Перенести все методы в отдельный класс)
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;

namespace homework6._8
{
    class Program
    {
        static void Main()
        {
            
            //начало программы
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine(
                "Программа для формирования нового массива В, состоящий из положительных элементов массива А\n" +
                "Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            int consoleInput = myMethodsClass.InputArrayCountMethod(inputNumber);

            int[] array_A = new int[consoleInput];

            for (int i = 0; i < array_A.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                string inputElement = Console.ReadLine();
                int element = myMethodsClass.InputArrayElementsMethod(inputElement);

                array_A[i] = element;
            }

            var result = myMethodsClass.CalculateMethod(array_A);
            myMethodsClass.PrintResultMethod(result);

            


            // Delay
            Console.ReadKey();
        }
    }
}