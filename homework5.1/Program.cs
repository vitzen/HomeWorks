﻿// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.
 

namespace homework5._1
{
    class Program
    {
        static void Main()
        {
            /// Метод для подсчета суммы элементов одномерного массива
            static int[] CalculateNethod(bool argument, int inputNumberArgument)
            {
                return;
            }
            
            
            
            //Ввод с консоли

            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);

            //int result = CalculateNethod(bool consoleInput, int arrayElementsCount);
            

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