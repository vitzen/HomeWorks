//Задание с сайта https://pas1.ru/taskcycle
//Используя 2 цикла вывести таблицу умножения

using System;

namespace homework4._9d
{
    class Program
    {
        static void Main(string[] args)
        {
          

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
               for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine((i * j)/3);
                    
                }
            }

            
            
            
            
            
            
            
            

            // Delay
            Console.ReadKey();
        }
    }
}