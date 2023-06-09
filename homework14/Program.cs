// 1) Учимся работать с Dictionary.
// На примере продуктов или транспортной карты изучаем основные методы работы с данной коллекцией -
// добавление, удаление и тд.
// 2) Делаем список линков, на основе продуктовой корзины. 
// Дано: список продуктовых корзин, в каждой продуктовой корзине есть свой список продуктов
// выбрать такие корзины, в которых сумма всех продуктов больше 100
// выбрать такие продукты, у которых название длинее 5 символов и цена больше 10
// выбрать такие корзины, у которых более 4 продуктов 
// выбрать продукты из всех корзин, у которых цена в интервале от 10 до 00
// выбрать для каждой корзины продукт с максимальной ценой в рамках данной корзины
// посчитать сумму всех продуктов в рамках каждой корзины
// посмитчать сумму всех продуктов для всех корзин суммарно

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using homework14;

namespace ConsoleApp6Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var cowsMilk = new Product(100, "Cows Milk");
            var goatMilk = new Product(100, "Goat Milk");
            var potato = new Product(102, "Potato");
            var carrot = new Product(80, "Сarrot") { IsNew = true };
            var onion = new Product(80, "Onion");
            var beet = new Product(60, "Beet");
            var seasoning = new Product(20, "Seasoning");
            var parsley = new Product(80, "Parsley");
            var celery = new Product(70, "Celery") { IsNew = true };
            var bellPepper = new Product(70, "Bell Pepper");

            //1-ая продуктовая корзина
            var card1 = new ProductCard(new List<Product>()
                { cowsMilk, potato, onion, seasoning, parsley, bellPepper });

            //2-ая продуктовая корзина
            var card2 = new ProductCard(new List<Product>()
                { bellPepper, beet, carrot, goatMilk, bellPepper, beet, potato });

            //3-яя продуктовая корзина
            var card3 = new ProductCard(new List<Product>()
                { goatMilk, beet, bellPepper, seasoning, onion, celery, carrot });

            //Список продуктовых корзин
            var listOfCards = new List<ProductCard>() { card1, card2, card3 };

            // Задание: выбрать такие корзины, в которых сумма всех продуктов больше 100
            var a = listOfCards
                .Select(x => x)
                .Where(x => x.Items.Pr > 100 )
                .OrderBy(x => x.Price)
                .Select(x => x.Title)
                .ToArray();

            Console.WriteLine(String.Join("\n", a));
        }
    }
}