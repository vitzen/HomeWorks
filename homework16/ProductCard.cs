using System;
using System.Collections.Generic;
using System.Text;

namespace homework16
{
    public class ProductCard
    {
        public string Name;
        public List<Product> Items { get; }

        public ProductCard(List<Product> products, string cartName)
        {
            Items = products;
            Name = cartName;
        }

        public override string ToString()
        {
            return $"Items: {Items}";
        }
    }
}


// var thread1 = new Thread(x =>
// {
//     var sumOfCard1 = arrayOfCards
//         .Where(x => x.Name is "Product Card 1")
//         .SelectMany(x => x.Items)
//         .Sum(x => x.Price);
//     //.ToString
//
//     flag1.Set();
// });
//
// var thread2 = new Thread(x =>
// {
//     var sumOfCard2 = arrayOfCards
//         .Where(x => x.Name is "Product Card 2")
//         .SelectMany(x => x.Items)
//         .Sum(x => x.Price);
//     //.ToString();
//
//     flag2.Set();
// });
//
// var thread3 = new Thread(x =>
// {
//     var sumOfCard3 = arrayOfCards
//         .Where(x => x.Name is "Product Card 3")
//         .SelectMany(x => x.Items)
//         .Sum(x => x.Price);
//     //.ToString();
//
//     flag3.Set();
// });