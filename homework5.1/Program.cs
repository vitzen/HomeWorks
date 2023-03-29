// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework5._1
{
    class Program
    {
        static int[] CalculateMethod(string inputFromConsole)
        {
            bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);
            int[] myArray = new int[arrayElementsCount];
            if (consoleInput)
            {
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

                // int sumOfArrayElements = myArray.Sum();
                // Console.WriteLine($"Элементы вашего массива: {string.Join(" ", myArray)}");
                // Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");
            }

            else
            {
                Console.WriteLine("Введите корректное число элементов в вашем массиве");
            }

            return myArray;
        }

        static void Main()
        {
            //Ввод с консоли

            Console.WriteLine("Введите размерность (количество элементов) массива");
            string inp = Console.ReadLine();
            CalculateMethod(string inp);

            


            // Delay
            Console.ReadKey();
        }
    }
}