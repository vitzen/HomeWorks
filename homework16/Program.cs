// Дан массив продуктовых корзин ProductCard[] cards
// Необходимо проинициализировать его данными и посчитать сумму всех продуктов во всех корзинах.
// При этом, сделать расчет суммы продуктов для каждой корзины параллельно. То есть 1 поток - 1 продуктовая корзина.
// По аналогии тому, как мы сделали сумму всех объемов для списка фигур.
// Только не в 2 потока, а в столько потоков, сколько продуктовых корзин.

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;

namespace homework16
{
    class Program
    {
        static void Main(string[] args)
        {
            var cowsMilk = new Product(100, "Cows Milk");
            var goatMilk = new Product(100, "Goat Milk");
            var potato = new Product(10, "Potato");
            var carrot = new Product(80, "Сarrot") { IsNew = true };
            var onion = new Product(80, "Onion");
            var beet = new Product(60, "Beet");
            var seasoning = new Product(20, "Seasoning");
            var parsley = new Product(80, "Parsley");
            var celery = new Product(70, "Celery") { IsNew = true };
            var bellPepper = new Product(70, "Bell Pepper");

            //1-ая продуктовая корзина
            var card1 = new ProductCard(new List<Product>()
                { cowsMilk, potato, onion, seasoning, parsley, bellPepper }, "Product Card 1");

            //2-ая продуктовая корзина
            var card2 = new ProductCard(new List<Product>()
                { bellPepper, beet, carrot, goatMilk, bellPepper, beet, potato }, "Product Card 2");

            //3-яя продуктовая корзина
            var card3 = new ProductCard(new List<Product>()
                { goatMilk, beet, bellPepper, seasoning, onion, celery, carrot }, "Product Card 3");

            //Список продуктовых корзин
            var listOfCards = new List<ProductCard>() { card1, card2, card3 };

            decimal totalSumm = 0;
            int threadsCount = 3;

            //Создаем флаги для потоков

            AutoResetEvent[] myFlags = new AutoResetEvent[threadsCount];

            //Создаем массив потоков и передаем в массив 
            Thread[] myThreads = new Thread[threadsCount];
            for (int i = 0; i < threadsCount; i++)
            {
                int doubler = i; // дублер
                myThreads[i] = new Thread(o =>
                {
                    var sum = listOfCards
                        .Where((_, y) => y % threadsCount == doubler)
                        .SelectMany(x => x.Items)
                        .Sum(x => x.Price);

                    totalSumm += sum;
                    Console.WriteLine($"Сумма с итерации {sum}");
                    myFlags[doubler].Set();
                })

                {
                    IsBackground = true
                };
                myFlags[i] = new AutoResetEvent(false);
            }

            for (int i = 0; i < 3; i++)
            {
                myThreads[i].Start();
            }

            if (WaitHandle.WaitAll(myFlags, TimeSpan.FromMilliseconds(1000)))
            {
                Console.WriteLine($"Сумма всех продуктов из продуктовых корзин равна: {totalSumm}");
            }
            else
            {
                Console.WriteLine($"Не удалось посчитать сумму.");
            }

            Console.WriteLine(new string('-', 60));
        }
    }
}