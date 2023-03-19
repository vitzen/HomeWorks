// Считать 2 строки с консоли и повыполнять операции над этими строками (5 операций) и результаты вывести

namespace hometask3._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int countOfStrings = 0;
            string[] firstString;

            // Создаем в памяти место для массива    
            
            firstString = new string [countOfStrings];

           

            do
            {
                Console.WriteLine("Введите первую строку из произвольных символов");
                
                
                
                
                if (firstString != "")
                {
                }
            }



            Console.WriteLine("Введите вторую строку из произвольных символов");
            string secondString = Console.ReadLine();

            // Блок арифметических операций
            Console.WriteLine(
                "Введите номер операции со строками: \n 1 - склеивание строк \n 2 - Подсчитать количество символов в каждой строке \n");
            string operationWithStrings = Console.ReadLine();


            // Delay.
            Console.ReadKey();
        }
    }
}