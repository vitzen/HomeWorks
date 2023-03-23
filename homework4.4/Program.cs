// Домашнее задание
// 4. В заданном одномерном массиве, состоящем из n целых чисел, подсчитать количество четных элементов.
using System;

namespace homework4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            bool num = Int32.TryParse(inputNumber, out int ArrayCountNumber);

            if (num)
            {
                int[] myArray = new int[]; 
                for (int i = 0; i < UPPER; i++)
                {
                    
                }
                Console.WriteLine("Введите целочисленные элементы массива");
                
                
                
                
                
                
                
                
            }
            else
            {
                Console.WriteLine("Неправильно введено число, попробуйте заново");
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            

            // Delay
            Console.ReadKey();
        }
    }
}