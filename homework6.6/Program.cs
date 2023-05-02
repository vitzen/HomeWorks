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

            Console.WriteLine("Программа для поиска наименьшего элемента одномерного массива");

            int inputElementsCount = MyMethodsClass.InputArrayCountMethod();

            int[] array = MyMethodsClass.InputArrayElementsMethod(inputElementsCount);

            int result = MyMethodsClass.CalculateMethod(array);

            MyMethodsClass.PrintResultMethod(array, result);

            Console.ReadKey();
        }
    }
}