// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework5._1
{
    class Program
    {
        /// <summary>
        /// Парсим все символы от пользователя
        /// </summary>
        public static void ParsingMethod()
        {
            
        }
        
        /// <summary>
        /// Операции с массивом
        /// </summary>
        public static void CalculateMethod()
        {
            
        }
        
        /// <summary>
        /// Выводим на консоль
        /// </summary>
        public static void PrintMethod()
        {
            
        }
        
        
        public static void Main()
        {
            //Программа для подсчета суммы элементов одномерного массива

            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            Console.WriteLine("Введите число");
            string number = Console.ReadLine();
            
            ParsingMethod(inputFromConsole, number);
            
            
            
            
            
            
            
            
            bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);

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