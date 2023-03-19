using System;
using System.Globalization;
using System.IO;
using System.Threading.Channels;

// Создать консольный проект, который будет считывать данные (2 числа)
// Сделать над ними все возможные операции и вывести результат

namespace homework3._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // double num1 = 0;
            // double num2 = 0;

            // Проверка первого и второго числа на правильность ввода
            do
            {
                Console.WriteLine("Для арифметической операции введите с клавиатуры первое число");
                string firstConsoleNumber = Console.ReadLine();
                bool numberOne = Double.TryParse(firstConsoleNumber, out double num1);


                if (numberOne)
                {
                    Console.WriteLine("введите с клавиатуры второе число");
                    string secondConsoleNumber = Console.ReadLine();
                    bool numberTwo = Double.TryParse(secondConsoleNumber, out double num2);

                    if (numberTwo)
                    {
                        Console.WriteLine("введите арифметическую операцию");
                        string ArithmeticOperation = Console.ReadLine();

                        // Блок арифметических операций
                        switch (ArithmeticOperation)
                        {
                            case "+":
                                Console.WriteLine($"Сумма двух чисел равна = {num1 + num2}");
                                break;
                            case "-":
                                Console.WriteLine($"Разность двух чисел равна = {num1 - num2}");
                                break;
                            case "*":
                                Console.WriteLine($"Результат от умножения двух чисел равен = {num1 * num2}");
                                break;
                            case "/":
                                if (num2 != 0)
                                {
                                    Console.WriteLine($"Результат от деления двух чисел равен = {num1 / num2}");
                                    
                                }

                                else
                                {
                                    Console.WriteLine("На ноль делить нельзя");
                                }

                                break;
                            case "%":
                                Console.WriteLine($"Остаток от деления двух чисел равен = {num1 % num2}");
                                break;
                            default:
                                Console.WriteLine("Вы ввели некорректную арифметическую операцию");
                                break;
                        }
                    }


                    else
                    {
                        Console.WriteLine("Вы ввели некорректные данные, введите 2-ое число корректно");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные, введите 1-ое число");
                }

                break;

                // Проверка второго числа на правильность ввода
            } while (true);


            // Delay.
            Console.ReadLine();
        }
    }
}