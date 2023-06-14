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
            //var listOfCards = new List<ProductCard>() { card1, card2, card3 };
            var arrayOfCards = new ProductCard [3] { card1, card2, card3 };

            decimal sumOfCard1 = 0;
            decimal sumOfCard2 = 0;
            decimal sumOfCard3 = 0;
            decimal totalSumm = 0;

            AutoResetEvent flag1 = new AutoResetEvent(false);
            AutoResetEvent flag2 = new AutoResetEvent(false);
            AutoResetEvent flag3 = new AutoResetEvent(false);

            var thread1 = new Thread(x =>
            {
                var sumOfCard1 = arrayOfCards
                    .Where(x => x.Name is "Product Card 1")
                    .SelectMany(x => x.Items)
                    .Sum(x => x.Price);
                //.ToString

                flag1.Set();
            });

            var thread2 = new Thread(x =>
            {
                var sumOfCard2 = arrayOfCards
                    .Where(x => x.Name is "Product Card 2")
                    .SelectMany(x => x.Items)
                    .Sum(x => x.Price);
                //.ToString();

                flag2.Set();
            });

            var thread3 = new Thread(x =>
            {
                var sumOfCard3 = arrayOfCards
                    .Where(x => x.Name is "Product Card 3")
                    .SelectMany(x => x.Items)
                    .Sum(x => x.Price);
                //.ToString();

                flag3.Set();
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();

            //Thread.Sleep(5000);

            if (WaitHandle.WaitAll(new[] { flag1, flag2, flag3 }, TimeSpan.FromSeconds(5)))
            {
                totalSumm = sumOfCard1 + sumOfCard2 + sumOfCard3;
            }
            else
            {
                Console.WriteLine($"Не удалось посчитать сумму.");
            }
            Console.WriteLine("Сумма всех продуктов во всех корзинах: ");
            Console.WriteLine(String.Join("\n", totalSumm));
            Console.WriteLine(new string('-', 60));
        }
    }
}