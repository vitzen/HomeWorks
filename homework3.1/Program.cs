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
                Console.WriteLine("Для выполнения арифметической операции введите с клавиатуры первое число");
                string firstConsoleNumber = Console.ReadLine();
                bool numberOne = Double.TryParse(firstConsoleNumber, out double num1);

                Console.WriteLine("введите с клавиатуры второе число");
                string secondConsoleNumber = Console.ReadLine();
                bool numberTwo = Double.TryParse(secondConsoleNumber, out double num2);


                if (numberOne && numberTwo)
                {
                    Console.WriteLine("введите с клавиатуры арифметическую операцию: +, -, *, / ");
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
                    Console.WriteLine("Вы ввели некорректные данные, введите оба числа заново \n" +
                                      (new string('-', 100))
                    );
                }
            } while (true);


        }
    }
}