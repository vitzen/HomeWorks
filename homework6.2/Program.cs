//Домашнее заданий 6.2
//Написать метод, который бы вернул кортеж данных
//Написать программу, подсчитывающую количество четных и нечетных чисел в массиве.


using System;

namespace homework6._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();

            Console.WriteLine("Программа, подсчитывающая количество четных и нечетных чисел в массиве\n");

            int consoleInput = MyMethodsClass.InputArrayCountMethod();
            int[] array = MyMethodsClass.InputArrayElementsMethod(consoleInput);


            (int even, int odd) = MyMethodsClass.CalculateMethod(array);
            MyMethodsClass.PrintResultMethod(even, odd);

            // Delay
            Console.ReadKey();
        }
    }
}