using System;

//Домашнее задание 2.1

namespace homework2._1
{
    class Program
    {
        static void Main()
        {
            string extended1 = "Вызван статический метод";

            // Вызов метода, как расширяющего
            extended1.ExtensionMethod();


            // Delay.
            Console.ReadKey();
        }
    }
}