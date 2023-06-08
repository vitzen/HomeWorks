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
        class LinqResult
        {
            public string Title { get; set; }
            public decimal Price { get; set; }

            public LinqResult(string title, decimal price)
            {
                Title = title;
                Price = price;
            }
        }

        static void Main(string[] args)
        {
            var milk1 = new Product(100, "Milk");
            var milk2 = new Product(100, "Milk");

            var milk3 = new Product(102, "Milk");
            var pr1 = new Product(80, "1") { IsNew = true };
            var pr2 = new Product(80, "2");
            var pr22 = new Product(60, "22");
            var pr23 = new Product(20, "23");
            var pr24 = new Product(80, "24");
            var pr3 = new Product(70, "3") { IsNew = true };
            var pr4 = new Product(70, "4");
            
            var card1 = new ProductCard(new List<Product>() { milk1, });
            var card2 = new ProductCard(new List<Product>() { milk1 });
            var card3 = new ProductCard(new List<Product>() { milk2, pr3, pr4, milk1, pr1, pr2 });
            

            var linq = card1.Items.Intersect(card2.Items).ToArray();

            var listOfCard = new List<ProductCard>() { card1, card2, card3 };

            
            var listOfUniqeTitles = listOfCard
                .SelectMany(x => x.Items)
                .Select(x => x.Title)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            // var first = listOfUniqeTitles..First();
            // var last = listOfUniqeTitles.Last();

            var groups = listOfCard
                .SelectMany(x => x.Items)
                .GroupBy(x => x.Title)
                .Select(x => new { Title = x.Key, Count = x.Count() })
                .Where(x => x.Count > 3)
                .ToArray();

            var groups1 = listOfCard
                .SelectMany(x => x.Items)
                .GroupBy(x => x.IsNew)
                .Select(x => new { Title = x.Key ? "NEW" : "OLD", Sum = x.Sum(y => y.Price) })
                .ToArray();


            var contains = card1.Items.Contains(milk1);


            


            var prods = listOfCard
                .SelectMany(x => x.Items)
                .Where(x => x.Price > 50 && x.Price < 100)
                .OrderBy(x => x.Price)
                .Select(x => x.Title)
                .ToArray();


            //var2
            var allProdsByLinq = listOfCard.SelectMany(x => x.Items).ToList();

            //
            //
            // var items = card1.Items.
            //     .OrderBy(x => x.Price)
            //     .ThenBy(x=>x.Title)
            //     .ToArray();


            Console.WriteLine($"{milk2 == milk2}");

            var list = new List<Product>();
            //
            list.Add(milk1);
            list.Add(milk2);
            list.Add(pr1);
            list.Add(pr2);
            list.Add(pr3);
            list.Add(pr4);

            list = list.Skip(400).ToList();

            var newProduct = new List<string>();

            foreach (var product in list)
            {
                if (product.IsNew)
                {
                    newProduct.Add(product.Title);
                }
            }

            Console.WriteLine("Новые продукты:");
            Console.WriteLine(string.Join(";", newProduct));

            var v = new { Amount = 108, Message = "Hello" };

            var newProductsByLinq = list
                .Where(product => product.IsNew == true)
                .Where(product => product.Price > 10)
                .Take(5)
                .Select(product => new LinqResult(product.Title, product.Price))
                .ToArray();

            return;

            //
            // list.RemoveAll(x => x == milk);
            //

            //Console.WriteLine($"{milk == milk1}");

            
        }
    }
}