//Задание с сайта https://pas1.ru/taskcycle
//Написать программу, подсчитывающую количество четных и нечетных цифр числа.

using System;

namespace homework4._8d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Блок ввода количества элементов массива
            Console.WriteLine("Введите количество чисел для работы программы");
            string inputConsoleNumber = Console.ReadLine();
            bool inputCounter = Int32.TryParse(inputConsoleNumber, out int inputCounterOfArrays);

            if (inputCounter)
            {
                double[] myArray = new double[inputCounterOfArrays];
                int evenCounter = 0;
                int oddCounter = 0;

                //Блок ввода чисел
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введите число");
                    string number = Console.ReadLine();
                    bool num = Int32.TryParse(number, out int numberForArrays);
                    
                    // Блок проверки числа на отрицательное или положительное
                    if (num && numberForArrays > 0 && numberForArrays % 2 == 0)
                    {
                        myArray[i] = numberForArrays;
                        evenCounter++;
                    }
                    else if (num && numberForArrays > 0 && numberForArrays % 2 == 1)
                    {
                        myArray[i] = numberForArrays;
                        oddCounter++;
                    }
                }


                Console.WriteLine($"Ваш список чисел: --> {String.Join(" | ", myArray)}\n" +
                                  $"Количество четных чисел равно = {evenCounter}\n" +
                                  $"Количество нечетных чисел равно = {oddCounter}");
            }
            else
            {
                Console.WriteLine("Введите корректное число чисел для работы программы");
            }


            // Delay
            Console.ReadKey();
        }
    }
}