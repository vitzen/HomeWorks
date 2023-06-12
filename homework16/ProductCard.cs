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