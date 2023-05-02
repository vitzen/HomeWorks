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
            Console.WriteLine("Программа для нахождения суммы элементов одномерного массива \n");


            int inputElementsCount = myMethodsClass.InputArrayCountMethod();

            int[] myArray = myMethodsClass.InputArrayElementsMethod(inputElementsCount);

            int result = myMethodsClass.CalculateMethod(myArray);

            myMethodsClass.PrintResultMethod(myArray, result);


            // Delay
            Console.ReadKey();
        }
    }
}