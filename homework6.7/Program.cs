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


            Console.WriteLine("Программа для подсчета суммы четных эементов массива \n");

            int consoleInput = MyMethodsClass.InputArrayCountMethod();

            int[] array = MyMethodsClass.InputArrayElementsMethod(consoleInput);

            int result = MyMethodsClass.CalculateMethod(array);
            MyMethodsClass.PrintResultMethod(array, result);

            // Delay
            Console.ReadKey();
        }
    }
}