// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework5._1
{
    class Program
    {
        static (int[], int sumOfArrayElements) CalculateMethod(string consoleInput)
        {
            //int sumOfArrayElements = 0;
            bool consoleInputNumber = Int32.TryParse(consoleInput, out int arrayElementsCount);
            int[] myArray = new int[arrayElementsCount];
            if (consoleInputNumber)

            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    string numberInp = InputArrayNumberMethod();
                    bool numberInput = Int32.TryParse(numberInp, out int num);
                    if (numberInput)
                    {
                        myArray[i] = num;
                    }
                    else
                    {
                        Console.WriteLine("Некорректно введенное число, Запускаем программу заново");
                    }
                }
            }

            else
            {
                Console.WriteLine("Введите корректное число элементов в вашем массиве");
            }

            int sumOfArrayElements = myArray.Sum();
            return (myArray, sumOfArrayElements);
        }

        ///Метод ввода размерности массива
        static void InputArraySizeMethod()
        {
            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inputSymbol = Console.ReadLine();
            CalculateMethod(inputSymbol);
        }

        ///Метод ввода чисел массива
        static string InputArrayNumberMethod()
        {
            Console.WriteLine("Введите число");
            string inputNumber = Console.ReadLine();
            return inputNumber;
        }


        static void Main()
        {
            Console.WriteLine("Программа для подсчета суммы элементов в массиве");


            Console.WriteLine($"Элементы вашего массива: {string.Join(" ", myArray)}");
            Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");


            // Delay
            Console.ReadKey();
        }
    }
}