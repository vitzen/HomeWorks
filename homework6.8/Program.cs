// Домашнее задание (Перенести все методы в отдельный класс)
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;

namespace homework6._8
{
    class Program
    {
        static void Main()
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine(
                "Программа для формирования нового массива В, состоящий из положительных элементов массива А\n");

            int consoleInput = MyMethodsClass.InputArrayCountMethod();

            int[] array_A = MyMethodsClass.InputArrayElementsMethod(consoleInput);

            var result = MyMethodsClass.CalculateMethod(array_A);

            MyMethodsClass.PrintResultMethod(result);

            // Delay
            Console.ReadKey();
        }
    }
}