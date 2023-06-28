// Написать программу. Дан список чисел(одномерный массив).
// Нужно в количестве равном N создать таски, внутри которых будет расчет факториалов
// для каждого числа из заданного списка.
// То есть параллельно пробежаться по списку чисел и распораллелить вычисление факториалов.
// Измерить время выполнения для однопоточной обработки списка(N=1) и для N=4(степень параллелизма) 

using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homework18._2
{
    public class Program
    {
        public static void Main()
        {
            int tasksCount = 10;
            int newArrayLength = 30;

            //Создаем объект синхронизации
            object _sync = new object();

            //Создаем очередь для рандомных чисел
            Queue<int> FibonachiNumbers = new Queue<int>();

            var result = Mathematics.GetCollectionOfNumbers(newArrayLength);
            Console.WriteLine("Дан рандомный список чисел");
            Console.WriteLine(String.Join(",", result));
            Console.WriteLine(new string('-', 90));

            for (int i = 0; i < result.Length; i++)
            {
                FibonachiNumbers.Enqueue(result[i]);
            }

            Console.WriteLine("Расчет факториала для каждого числа из рандомной последовательности:");

            //Создаем Tasks
            for (int i = 0; i < tasksCount; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    //lock (_sync)
                    {
                        for (int i = 0; i < FibonachiNumbers.Count; i++)
                        {
                            FibonachiNumbers.TryDequeue(out int num);
                            int res = Mathematics.GetFactorialFromNumbers(num);
                            Console.WriteLine($"!{num} = {res}");
                        }
                    }
                });
            }
        }
    }
}