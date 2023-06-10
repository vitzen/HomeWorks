// var listOfUniqeTitles = listOfCard
            //     .SelectMany(x => x.Items)
            //     .Select(x => x.Title)
            //     .Distinct()
            //     .OrderBy(x => x)
            //     .ToArray();
            //
            // // var first = listOfUniqeTitles..First();
            // // var last = listOfUniqeTitles.Last();
            //
            // var groups = listOfCard
            //     .SelectMany(x => x.Items)
            //     .GroupBy(x => x.Title)
            //     .Select(x => new { Title = x.Key, Count = x.Count() })
            //     .Where(x => x.Count > 3)
            //     .ToArray();
            //
            // var groups1 = listOfCard
            //     .SelectMany(x => x.Items)
            //     .GroupBy(x => x.IsNew)
            //     .Select(x => new { Title = x.Key ? "NEW" : "OLD", Sum = x.Sum(y => y.Price) })
            //     .ToArray();
            //
            //
            // var contains = card1.Items.Contains(milk1);
            //
            //
            // var prods = listOfCard
            //     .SelectMany(x => x.Items)
            //     .Where(x => x.Price > 50 && x.Price < 100)
            //     .OrderBy(x => x.Price)
            //     .Select(x => x.Title)
            //     .ToArray();
            //
            //
            // //var2
            // var allProdsByLinq = listOfCard.SelectMany(x => x.Items).ToList();
            //
            // //
            // //
            // // var items = card1.Items.
            // //     .OrderBy(x => x.Price)
            // //     .ThenBy(x=>x.Title)
            // //     .ToArray();
            //
            //
            // Console.WriteLine($"{milk2 == milk2}");
            //
            // var list = new List<Product>();
            // //
            // list.Add(milk1);
            // list.Add(milk2);
            // list.Add(pr1);
            // list.Add(pr2);
            // list.Add(pr3);
            // list.Add(pr4);
            //
            // list = list.Skip(400).ToList();
            //
            // var newProduct = new List<string>();
            //
            
            // Console.WriteLine("Новые продукты:");
            // Console.WriteLine(string.Join(";", newProduct));
            //
            // var v = new { Amount = 108, Message = "Hello" };
            //
            // var newProductsByLinq = list
            //     .Where(product => product.IsNew == true)
            //     .Where(product => product.Price > 10)
            //     .Take(5)
            //     .Select(product => new LinqResult(product.Title, product.Price))
            //     .ToArray();
            //
            // return;

            //
            // list.RemoveAll(x => x == milk);
            //

            //Console.WriteLine($"{milk == milk1}");