// Домашнее задание
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework4._1
{
    class Program
    {
        static void PrintMetod(string inputArgument1, string inputArgument2)
        {
            bool consoleInput = Int32.TryParse(inputArgument1, out int arrayElementsCount);
            if (consoleInput)
            {
                
                
            }
            
            
            
            
            
        }

        
        
        
        
        
        
        static void CalculateMethod()
        {
            int[] myArray = new int[arrayElementsCount];
        }


        static void Main()
        {
            //Ввод с консоли данных пользователя
            Console.WriteLine("Программа для подсчета суммы элементов одномерного массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine(); //Ввод с консоли размерности массива
           
            Console.WriteLine("Введите число"); //Ввод с консоли чисел
            string number = Console.ReadLine();
            
            PrintMetod(inputFromConsole, number);
            
            
            
            
            
            bool consoleInput = Int32.TryParse(inputFromConsole, out int arrayElementsCount);

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