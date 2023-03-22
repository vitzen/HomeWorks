// Считать 2 строки с консоли и повыполнять операции над этими строками (5 операций) и результаты вывести

namespace homework3._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opNumber = 0;
            //Блок ввода строк
            Console.WriteLine("Программа для выполнения операций со строками: \n Введите первую строку");
            string inputString1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string inputString2 = Console.ReadLine();

            //Блок ввода номера операции со строками
            Console.WriteLine("Введите с клавиатуры номер операции для работы со строками и нажмите ENTER:");
            string numberOfOperation = Console.ReadLine();
            bool operation = Int32.TryParse(string numberOfOperation, out int opNumber);


            // Delay.
            Console.ReadKey();
        }
    }
}