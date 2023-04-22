// Домашнее задание (Перенести все методы в отдельный класс)
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework6._4
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
            static int CalculateMethod(int[] newArray)
            {
                int sumOfArrayElements = newArray.Sum();
                return sumOfArrayElements;
            }

            /// Метод для вывода решения
            static void PrintResultMethod(int[] newArray, int sumOfArrayElements)
            {
                Console.WriteLine($"Элементы вашего массива: {string.Join(" ", newArray)}");
                Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");
            }


            //Программа для нахождения суммы элементов одномерного массива
            Console.WriteLine("Программа для нахождения суммы элементов одномерного массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            int inputElementsCount = InputArrayCountMethod(inputFromConsole);

            int[] array = new int[inputElementsCount];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число");
                string number = Console.ReadLine();
                int element = InputArrayElementsMethod(number);
                array[i] = element;
            }

            int result = CalculateMethod(array);

            PrintResultMethod(array, result);


            // Delay
            Console.ReadKey();
        }
    }
}