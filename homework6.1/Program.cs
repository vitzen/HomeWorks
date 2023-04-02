//Домашнее заданий 6.1
//Написать метод-рекурсию для вычисления N-ого элемента последовтельности Фиббоначчи

using System;

namespace homework6._1
{
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Программа для вычисления N-ого элемента последовтельности Фиббоначчи, используя метод-рекурсию ");
            int number;
            result = 0;
            int Recursion(number)
            {
                if (number == 0)
                {
                    return 1;
                }

                else
                {
                    result = Recursion((number-1)*number));
                }
                
                
              
            }
            
            
            
            
            







            // Delay
            Console.ReadKey();
        }
    }
}