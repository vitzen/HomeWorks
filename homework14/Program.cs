using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;

namespace homework14
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

            // Задание: выбрать такие корзины, в которых сумма всех продуктов больше 100
            var moreThen100 = listOfCards
                .Where(x => x.Items.Sum(y => y.Price) > 100)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine("Корзины, в которых сумма всех продуктов больше 100: ");
            Console.WriteLine(String.Join("\n", moreThen100));
            Console.WriteLine(new string('-', 60));

            // Задание: выбрать такие продукты, у которых название длинее 5 символов и цена больше 10
            var moreThen100Symbols = listOfCards
                .SelectMany(x => x.Items)
                .Where(x => x.Title.Length > 5 && x.Price > 10)
                .Select(x => x.Title)
                .ToList();

            Console.WriteLine("Продукты, у которых название длинее 5 символов и цена больше 10: ");
            Console.WriteLine(String.Join("\n", moreThen100Symbols));
            Console.WriteLine(new string('-', 60));

            //Задание: выбрать такие корзины, у которых более 4 продуктов 
            var cardWithMore4Products = listOfCards
                .Where(x => x.Items.Count > 4)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine("Корзины, в которых более 4 продуктов: ");
            Console.WriteLine(String.Join("\n", cardWithMore4Products));
            Console.WriteLine(new string('-', 60));

            //Задание: выбрать продукты из всех корзин, у которых цена в интервале от 10 до 100
            var productsInRange = listOfCards
                .SelectMany(x => x.Items)
                .Where(x => x.Price > 10 && x.Price < 100)
                .Select(x => x.Title)
                .ToList();

            Console.WriteLine("Все продукты, цена которых в диапазоне от 10 до 100: ");
            Console.WriteLine(String.Join("\n", productsInRange));
            Console.WriteLine(new string('-', 60));

            //Задание: выбрать для каждой корзины продукт с максимальной ценой в рамках данной корзины 
            var productWithMaxPrice = listOfCards
                .Select(x => new
                { 
                    product = x.Items.OrderByDescending(y => y.Price).First(),
                    title = x.Name
                })
                .ToList();

            Console.WriteLine("Продукт с максимальной ценой: ");
            Console.WriteLine(String.Join("\n", productWithMaxPrice));
            Console.WriteLine(new string('-', 60));

            //Задание: посчитать сумму всех продуктов в рамках каждой корзины
            var SumOfProductsInCard = listOfCards
                .Select(x => new
                {
                    Title = x.Name,
                    Sum = x.Items.Sum(y => y.Price)
                })
                .ToList();

            Console.WriteLine("Сумма всех продуктов в рамках корзины: ");
            Console.WriteLine(String.Join("\n", SumOfProductsInCard));
            Console.WriteLine(new string('-', 60));


            //Задание: посчитать сумму всех продуктов для всех корзин суммарно
            var SumOfAllProducts = listOfCards
                .SelectMany(x => x.Items)
                .Sum(x => x.Price)
                .ToString();
            Console.WriteLine("Сумма всех продуктов во всех корзинахы: ");
            Console.WriteLine(String.Join("\n", SumOfAllProducts));
            Console.WriteLine(new string('-', 60));
        }
    }
}