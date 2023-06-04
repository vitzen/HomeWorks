using System;

namespace homework14
{
    public class Product
    {
        public decimal Price { get; }
        public string Title { get; }
        public int Id { get; set; }
        public bool IsNew { get; set; }

        public Product(decimal price, string title)
        {
            Price = price;
            Title = title;
        }

        public Product(decimal price, string title, bool isNew) : this(price, title)
        {
            IsNew = isNew;
        }

        public override string ToString()
        {
            return $"Title: {Title}. Price: {Price:N0}";
        }
    }
}