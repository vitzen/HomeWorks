// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;

namespace homework5._5
{
    class Program
    {
        static void Main()
        {
            //начало программы
            Console.WriteLine(
                "Программа для формирования нового массива В, состоящий из положительных элементов массива А\n" +
                "Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputNumber);

            int[] array_A = new int[consoleInput];

            for (int i = 0; i < array_A.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                string inputElement = Console.ReadLine();
                int element = InputArrayElementsMethod(inputElement);

                array_A[i] = element;
            }

            var result = CalculateMethod(array_A);
            PrintResultMethod(result);

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
            static int[] CalculateMethod(int[] array_B)
            {
                int indexOfNewArray = 0;
                int newArrayElementsCount = 0;


                for (int i = 0;
                     i < array_B.Length;
                     i++) //Цикл подсчета количества положительных элементов в новом массиве
                {
                    if (array_B[i] > 0)
                    {
                        newArrayElementsCount++;
                    }
                }

                int[] array_C =
                    new int[newArrayElementsCount]; //Инициализация нового массива с новым количеством элементов
                for (int j = 0; j < array_B.Length; j++) //Цикл для заполнения нового массива положительными элементами
                {
                    int currentNumber = array_B[j];
                    if (currentNumber > 0)
                    {
                        array_C[indexOfNewArray++] = currentNumber;
                    }
                }

                return array_C;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] printResult)
            {
                Console.WriteLine($"Элементы нового массива: {string.Join(" ", printResult)}");
            }


            // Delay
            Console.ReadKey();
        }
    }
}