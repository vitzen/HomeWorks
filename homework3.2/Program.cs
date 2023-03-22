// Считать 2 строки с консоли и повыполнять операции над этими строками (5 операций) и результаты вывести

using System.Drawing;
using System.Linq;

namespace homework3._2
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            
            int string1Length = 0;
            int string2Length = 0;

            do
            {
                
                //Блок ввода строк
                Console.WriteLine("Программа для выполнения операций со строками: \n Введите первую строку");
                string inputString1 = Console.ReadLine();
                string1Length = inputString1.Length;
                
                Console.WriteLine("Введите вторую строку");
                string inputString2 = Console.ReadLine();
                string2Length = inputString2.Length;

                //Блок ввода номера операции со строками
                Console.WriteLine("Введите с клавиатуры номер операции для работы со строками и нажмите ENTER:");
                Console.WriteLine("1 - Склеивание строк \n " +
                                  "2 - Подсчитать количество символов в каждой строке \n " +
                                  "3 - Вставить в начало каждой строки индивидуальный идентификатор <ID-Maxima_School> \n" +
                                  "4 - Удаление первых 2-ух символов из каждой строки \n" +
                                  "5 - Удалить последний символ в каждой строке \n");

                string numberOfOperation = Console.ReadLine();
                bool operation = Int32.TryParse(numberOfOperation, out int opNumber);


                switch (opNumber)
                {
                    case 1:
                        Console.WriteLine(inputString1 + inputString2);
                        break;
                    case 2:
                        Console.WriteLine($"Количество символов в первой строке {inputString1.Length} \n" +
                                          $"Количество символов во второй строке {inputString2.Length}");
                        break;
                    case 3:
                        Console.WriteLine($"Полученные новые строки: \n" +
                                          $"{inputString1.Insert(0, "ID - Maxima_School")} \n" +
                                          $"{inputString2.Insert(0, "ID - Maxima_School")}");
                        break;
                    case 4:
                        Console.WriteLine($"Полученные новые строки: \n" +
                                          $"{inputString1.Remove(0,2)} \n" +
                                          $"{inputString2.Remove(0,2)}");
                        break;
                    case 5:
                        Console.WriteLine($"Полученные новые строки: \n" +
                                          $"{inputString1.Remove(string1Length - 1)} \n" +
                                          $"{inputString2.Remove(string2Length - 1)}");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверный номер операции");
                        break;
                }
                Console.WriteLine(new string('-', 50));
            } while (true);


            // Delay.
            Console.ReadKey();
        }
    }
}