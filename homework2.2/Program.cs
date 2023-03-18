using System;

//Домашнее задание 2.2

namespace homework2._2
{
    class Program
    {
        static void Main()
        {
            string extended2 = "Вызван статический метод";

            // 2-ой способ вызова метода, как расширяющего.
            ExtensionClass.ExtensionMethod(extended2);
            
            
            // Delay.
            Console.ReadKey();
        }
    }
}