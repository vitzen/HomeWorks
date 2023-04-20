//Задание с сайта https://pas1.ru/taskcycle
//Определить количество простых чисел
// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)

using System;
??????????????????????????????????????????????????????????????????????????????????????
namespace homework5._6d
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Метод парсинга размера массива
            static int InputArrayCountMethod(string inputFromConsole)
            {
                bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);
                if (!consoleInput)
                {
                    Console.WriteLine($"Введите корректное значение");
                }

                return arrayElementsCount;
            }

            /// Метод парсинга вводимых значений эелемнтов массива
            static int InputArrayElementsMethod(string number)
            {
                bool numberInput = Int32.TryParse(number, out int num);
                if (!numberInput)
                {
                    Console.WriteLine($"Введите корректное значение");
                }

                return num;
            }

            /// Метод для решения арифметических задач
            static (int, int[]) CalculateMethod(int[] newArray)
            {
                var myArray = newArray;
                int countOfEasyNumbers = 0;
                for (int i = 0; i < myArray.Length; i++)
                {
                    if ((myArray[i] > 0) && ((myArray[i] / myArray[i] == 1) || (myArray[i] / 1 == myArray[i])))
                    {
                        countOfEasyNumbers++;
                    }
                }

                return (countOfEasyNumbers, myArray);
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int counter, int[] ourArray)
            {
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", ourArray)}");
                Console.WriteLine($"Количество простых числео в массиве = {counter} ");
            }


            // Программа
            Console.WriteLine("Программа для подсчета количества простых чисел \n" +
                              "Введите количество чисел для подсчета суммы:");
            string inputConsoleCounter = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputConsoleCounter);


            int[] inputArray = new int[consoleInput];

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine("Введите число");
                string inputConsoleNumber = Console.ReadLine();
                int element = InputArrayElementsMethod(inputConsoleNumber);
                inputArray[i] = element;
            }

            (var countOfEasyNumbers, inputArray) = CalculateMethod(inputArray);
            PrintResultMethod(countOfEasyNumbers, inputArray);


            // Delay
            Console.ReadKey();
        }
    }
}