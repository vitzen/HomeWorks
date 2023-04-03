//Домашнее заданий 6.1
//Написать метод-рекурсию для вычисления N-ого элемента последовтельности Фиббоначчи

using System;

namespace homework6._1
{
    class Program
    {
        public static int Fibonachi(int n) //Метод для вычисления n-числа Фибоначчи
        {
            if (n == 0 || n == 1) return n;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }


        public static void Main() // Программа
        {
            Console.WriteLine(
                "Программа для вычисления N-ого элемента последовтельности Фиббоначчи, используя метод-рекурсию \n" +
                "Введите n-ый элемент для вычисления его в ряду Фибоначчи");
            string inputSymbol = Console.ReadLine();
            bool input = Int32.TryParse(inputSymbol, out int nElement);
            //int result = 0;
            if (input == true && nElement >= 0)
            {
                int result = Fibonachi(nElement);
            }
            else
            {
                Console.WriteLine("Введите число корректно");
            }


            //Console.WriteLine($"n-ое число Фибоначчи = {result}");


            // Delay
            Console.ReadKey();
        }
    }
}