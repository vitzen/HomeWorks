// Домашнее задание (Перенести все методы в отдельный класс)
// 3. Найти наименьший элемент одномерного массива, состоящего из n элементов. Элементы вводятся с клавиатуры.

using System;

namespace homework6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();

            Console.WriteLine("Введите размерность (количество элементов) массива");
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

            int result = myMethodsClass.CalculateMethod(array);
            myMethodsClass.PrintResultMethod(array, result);

            Console.ReadKey();
        }
    }
}