//Домашнее заданий 6.1
//Написать метод-рекурсию для вычисления N-ого элемента последовтельности Фиббоначчи

using System;

namespace homework6._1
{
    class Program
    {
        public static void Main()
        {
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine(
                "Программа для вычисления N-ого элемента последовтельности Фиббоначчи, используя метод-рекурсию \n");
            int intFromKeyboardInput = myMethodsClass.GetIntFromInput();
            
            int myFibonachiNumber = MyMethodsClass.Fibonachi(intFromKeyboardInput);
            
            MyMethodsClass.Print(myFibonachiNumber);

            // Delay
            Console.ReadKey();
        }
    }
}