// Домашнее задание (Перенести все методы в отдельный класс)
//1. Найти сумму элементов одномерного массива. Размер произвольный. Элементы вводятся с клавиатуры.

namespace homework6._4
{
    class Program
    {
        public static void Main()
        {
            //Программа для нахождения суммы элементов одномерного массива
            MyMethodsClass myMethodsClass = new MyMethodsClass();
            Console.WriteLine("Программа для нахождения суммы элементов одномерного массива \n" +
                              "Введите размерность (количество элементов) массива");
            string inputFromConsole = Console.ReadLine();
            int inputElementsCount = myMethodsClass.InputArrayCountMethod(inputFromConsole);

            int[] array = new int[inputElementsCount];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите число");
                string number = Console.ReadLine();
                int element = myMethodsClass.InputArrayElementsMethod(number);
                array[i] = element;
            }

            int result = myMethodsClass.CalculateMethod(array);

            myMethodsClass.PrintResultMethod(array, result);


            // Delay
            Console.ReadKey();
        }
    }
}