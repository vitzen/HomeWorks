// Домашнее задание (ПЕРЕДЕЛАТЬ ЗАДАНИЕ НА МЕТОДЫ)
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework5._1
{
    class Program
    {
        /// <summary>
        /// Метод отвечающий за преобразование введенных с консоли пользователем чисел
        /// </summary>
        /// <param name="inputArgument1"></param>
        /// <param name="inputArgument2"></param>
        static int PrintMetod(string inputArgument1, string inputArgument2)
        {
            bool consoleInput = Int32.TryParse(inputArgument1, out int arrayElementsCount);
            bool numberInput = Int32.TryParse(inputArgument2, out int arrayElements);
            if (consoleInput && numberInput)
            {
                CalculateMethod(arrayElementsCount, arrayElements);
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }

            return arrayElementsCount;
        }

        /// <summary>
        /// Метод для операций с элементами массива
        /// </summary>
        /// <param name="inputArgument1"></param>
        /// <param name="inputArgument2"></param>
        static int[] CalculateMethod(int inputArgument3, int inputArgument4)
        {
            int[] myArray = new int[inputArgument3];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = inputArgument4;
            }

            return myArray;
        }
    }


    public static void Main()
    {
        int inputCounter = 0; //Размерность массива / счетчик
        
        //Ввод с консоли данных пользователя
        Console.WriteLine("Программа для подсчета суммы элементов одномерного массива \n" +
                          "Введите размерность (количество элементов) массива");
        string inputFromConsole = Console.ReadLine(); //Ввод с консоли размерности массива

        Console.WriteLine("Введите число"); //Ввод с консоли чисел
        string number = Console.ReadLine();
        do
        {
            int inputCounter = PrintMetod(inputFromConsole, number);
        } 
        while (expression);
        


        // Полученный после ввода массив данных
        
        //Console.WriteLine($"Элементы вашего массива: {string.Join(" ", myArray)}");
        int sumOfArrayElements = myArray.Sum();
        Console.WriteLine($"Сумма всех элементов в массиве равна = {sumOfArrayElements} ");


        // Delay
        Console.ReadKey();
    }
}

}