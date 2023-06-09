using System;

namespace homework14
{
    public class Product
    {
        public Product(decimal price, string title)
        {
            Price = price;
            Title = title;
        }
        
        public decimal Price { get; }
        public string Title { get; }
        public bool IsNew { get; set; }

        public Product(decimal price, string title, bool isNew) : this(price, title)
        {
            IsNew = isNew;
        }

        public override string ToString()
        {
            return $"Price: {Price}, Title: {Title}, IsNew: {IsNew}";
        }
    }
}