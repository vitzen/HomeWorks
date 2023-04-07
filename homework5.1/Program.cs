// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.
using System;

namespace homework5._1
{
    class Program
    {
        static void Main()
        {
            
            
            /// Метод
            void ParsingArrayCount(string input)
            {
                bool consoleInput = Int32.TryParse(input, out int arrayElementsCount);
                if (consoleInput)
                {
                    int[] myArray = new int[arrayElementsCount];
                    return 
                }

            }
            
           
            /// Метод
            public static void ParsingArrayNumbers()
            {
                return;
                
            }
            
            /// Метод
            public static void CalculateMethod()
            {
                return;
            }
            
            /// Метод
            public static void PrintInConsole()
            {
                return;
            }
            
            
            
            
            
            
            
            
            
            
            
            //Ввод с консоли

            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            ParsingArrayCount(inputFromConsole);
            
            

            if (consoleInput)
            {
                int[] myArray = new int[arrayElementsCount];
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите число");
                    string number = Console.ReadLine();
                    bool numberInput = Int32.TryParse(number, out int num);
                    if (numberInput)
                    {
                        myArray[i] = num;
                    }
                    else
                    {
                        Console.WriteLine("Некорректно введенное число, Запускаем программу заново");
                    }
                }

                // Полученный после ввода массив данных
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", myArray)}");
                int sumOfArrayElements = myArray.Sum();
                Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");
            }

            else
            {
                Console.WriteLine("Введите корректное число элементов в вашем массиве");
            }


            // Delay
            Console.ReadKey();
        }
    }
}