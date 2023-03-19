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
            // Проверка первого числа на правильность ввода
            do
            {
                Console.WriteLine("Для арифметической операции введите с клавиатуры первое число");
                string firstConsoleNumber = Console.ReadLine();

                bool numberOne = Int32.TryParse(firstConsoleNumber, out int num1);


                if (numberOne)
                {
                    // Console.WriteLine(num1);
                    Console.WriteLine("введите с клавиатуры второе число");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные, введите 1-ое число");
                }


                // Проверка второго числа на правильность ввода

                string secondConsoleNumber = Console.ReadLine();

                bool numberTwo = Int32.TryParse(secondConsoleNumber, out int num2);

                if (numberTwo)
                {
                    Console.WriteLine("введите арифметическую операцию");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные, введите 2-ое число корректно");
                }


                // Блок арифметических операций
                string ArithmeticOperation = Console.ReadLine();


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
                        Console.WriteLine($"Результат от деления двух чисел равен = {num1 / num2}");
                        break;
                    case "%":
                        Console.WriteLine($"Остаток от деления двух чисел равен = {num1 % num2}");
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректную арифметическую операцию");
                        break;
                }
            } while (true);

            // Delay.
            Console.ReadLine();
        }
    }
}