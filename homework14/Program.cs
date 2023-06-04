// ЗАДАЧА:
// 1) Учимся работать с Dictionary. На примере продуктов или транспортной карты
// изучаем основные методы работы с данной коллекцией - добавление, удаление и тд.
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
using System.IO;

namespace homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // EventHandler<ProductAddEventArgs> cardOnProductAddedEvent()
            // {
            //     return (sender, eventArgs) =>
            //     {
            //         var product = eventArgs.AddedProduct;
            //         Console.WriteLine($"Обработчик1. {product}"); 
            //     };
            // }
            //
            //
            // // EventHandler<ProductAddEventArgs> cardOnProductAddedEvent2()
            // // {
            // //     return (sender, eventArgs) =>
            // //     {
            // //         Console.WriteLine("Обработчик2"); 
            // //     };
            // // }
            // var pr1 = new Product(10000, "pr1");
            // var pr2 = new Product(99, "pr2");
            // var pr3 = new Product(10, "pr3");
            //
            // var card = new ProductCard(NotifyMagnit, NotifyOfSaleByConsole, CalculateSaleMagnit, obj => true );
            //
            // card.ProductAddedEvent += cardOnProductAddedEvent();
            // //card.ProductAddedEvent += cardOnProductAddedEvent2();
            //
            // card.AddProducts(new []{pr1, pr2, pr3});
            //
            // card.ProductAddedEvent -= cardOnProductAddedEvent();
            // //card.ProductAddedEvent -= cardOnProductAddedEvent2();

            return;

            // Console.WriteLine("perekrestok");
            // var card1 = new ProductCard(
            //     product => { Console.WriteLine($"Added new product: {product}"); },
            //     (sale, summOfSale) =>
            //     {
            //         Console.WriteLine($"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}");
            //     },
            //     (arg) => 0.8M, 
            //     summ =>
            //     {
            //         if (summ > 1000) return true;
            //         return false;
            //     });
            //
            // card1.AddProduct(pr1);
            // Console.WriteLine($"Total: {card1.GetTotalSumm():N0}");


            // Console.WriteLine("magin");
            // var card2 = new ProductCard(NotifyMagnit, NotifyOfSaleByConsole, CalculateSaleMagnit);
            // card2.AddProduct(pr2);
            // Console.WriteLine($"Total: {card2.GetTotalSumm():N0}");
            //
            // //
            // var card2 = new ProductCard(NotifyPerekrestok, NotifyOfSaleByFile);
            // Console.WriteLine($"Total: {card2.GetTotalSumm():N0}");

            // Console.WriteLine("DIKSI");
            // var productCardDiksi = new ProductCard(NotifyDiksi, NotifyOfSale);
            // productCardDiksi.AddProduct(pr1);
            // productCardDiksi.AddProduct(pr2);
            // productCardDiksi.AddProduct(pr3);
            //
            // Console.WriteLine("MAGNIT");
            // var productCardMagnit = new ProductCard(NotifyMagnit, NotifyOfSale);
            // productCardMagnit.AddProduct(pr1);

            // Console.WriteLine(productCard.PrintAllProduct());
        }

        
            Product pr1 = new Product(10000, "pr1");
            Product pr2 = new Product(99, "pr2");
            Product pr3 = new Product(10, "pr3");

            // var card = new ProductCard(NotifyMagnit, NotifyOfSaleByConsole, CalculateSaleMagnit, obj => true);
            //
            // card.BuyEvent += CardOnBuyEvent;
            // card.AddProducts(new []{pr1, pr2, pr3});
            // card.Buy();
            //
            // card.BuyEvent -= CardOnBuyEvent;
        

        private static void CardOnBuyEvent(object sender, decimal total)
        {
            Console.WriteLine($"Сделана покупка на сумму {total}");
        }

        public static void NotifyPerekrestok(Product product)
        {
            Console.WriteLine($"Added new product: {product}");
        }

        public static void NotifyDiksi(Product product)
        {
            Console.WriteLine($"Welcome! Added new product: {product}");
        }

        public static void NotifyMagnit(Product product)
        {
            //Console.WriteLine($"MAGNIT! Added new product: {product}");
        }

        public static void NotifyOfSaleByConsole(decimal sale, decimal summOfSale)
        {
            // Console.WriteLine($"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}");
        }

        public static void NotifyOfSaleByFile(decimal sale, decimal summOfSale)
        {
            var message = $"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}";
            File.WriteAllText("log.txt", message);
        }

        // private readonly Func<decimal, decimal> _calculateSaleFunc;

        public static decimal CalculateSaleMagnit(decimal summ)
        {
            decimal sale = 1;

            if (summ > 1000)
            {
                sale = 0.95M;
            }
            else if (summ > 100)
            {
                sale = 0.975M;
            }
            else if (summ > 25)
            {
                sale = 0.99M;
            }

            return sale;
        }

        public static decimal CalculateSalePerekrestok(decimal summ)
        {
            decimal sale = 0.9M;

            return sale;
        }
    }
}