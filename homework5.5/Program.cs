// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
// 5. Массив А вводится с клавиатуры. Сформировать новый массив В, состоящий из положительных элементов массива А. Размер произвольный.

using System;
?????????????????????????????????????????????????????????????????????????????????????????????????
namespace homework5._5
{
    class Program
    {
        static void Main()
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
            static int[] CalculateMethod(int[] array_B, int newArrayCounterNumber)
            {
                int indexOfNewArray = 0;
                for (int i = 0; i < newArrayCounterNumber; i++)
                {
                    int currentNumber = array_B[i];
                    if (currentNumber > 0)
                    {
                        array_B[indexOfNewArray++] = currentNumber;
                    }
                }

                return array_B;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] array_C)
            {
                Console.WriteLine($"Элементы нового массива: {string.Join(" ", array_C)}");
                
            }


            //Блок ввода количества элементов массива
            Console.WriteLine(
                "Программа для формирования нового массива В, состоящий из положительных элементов массива А\n" +
                "Введите количество элементов массива");
            string inputNumber = Console.ReadLine();
            int consoleInput = InputArrayCountMethod(inputNumber);

            int newArrayCounterNumber = consoleInput;
            int[] array_A = new int[consoleInput];
            int[] array_B = new int[newArrayCounterNumber];


            for (int i = 0; i < array_A.Length; i++)
            {
                Console.WriteLine("Введите элемент массива");
                string inputElement = Console.ReadLine();
                int element = InputArrayElementsMethod(inputElement);

                array_B[i] = element;
            }

            int[] array_C = CalculateMethod(array_B, newArrayCounterNumber);

            PrintResultMethod(array_C);

            

        // Delay
        Console.ReadKey();
    }
}

}