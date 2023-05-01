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
                "Программа для вычисления N-ого элемента последовтельности Фиббоначчи, используя метод-рекурсию \n" +
                "Введите n-ый элемент для вычисления его в ряду Фибоначчи");
            string inputSymbol = Console.ReadLine();
            int numberOfFibonachiElement = myMethodsClass.Parsing(inputSymbol);
            int myFibonachiNumber = MyMethodsClass.Fibonachi(numberOfFibonachiElement);
            MyMethodsClass.Print(myFibonachiNumber);

            // Delay
            Console.ReadKey();
        }
    }
}