// Считать 2 строки с консоли и повыполнять операции над этими строками (5 операций) и результаты вывести

namespace homework3._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int countOfStrings = 0; // Счетчик количества строк
            string[] firstString;
            string[] oldArray;
            string userString;
            int i;

            // Создаем в памяти место для массива    
            oldArray = new string [countOfStrings];


            do
            {
                Console.WriteLine("Введите строку из произвольных символов");
                userString = Console.ReadLine();

                if (userString != "")
                {
                    ++countOfStrings;


                    firstString = new string[countOfStrings];
                    for (i = 0; i < firstString.Length - 1; i++)
                    {
                        firstString[i] = oldArray[i];
                        firstString[countOfStrings] = userString;
                        firstString = oldArray;
                    }
                }
            } while (userString != "" && countOfStrings < 1);


            // Console.WriteLine("Введите вторую строку из произвольных символов");
            // string secondString = Console.ReadLine();

            // Блок арифметических операций
            Console.WriteLine(
                "Введите номер операции со строками: \n 1 - склеивание строк \n 2 - Подсчитать количество символов в каждой строке \n");
            string operationWithStrings = Console.ReadLine();
            switch (operationWithStrings)
            {
                case "1":
                {
                    Console.WriteLine(firstString + ...);
                    break;
                }
                case "2":
                {
                    Console.WriteLine(firstString.Length);
                    break;
                }
                default:
                    Console.WriteLine("Введите корректный номер операции");
                    break;
            }


            // Delay.
            Console.ReadKey();
        }
    }
}