using System;
using System.Collections.Generic;
using System.Text;

namespace homework14
{
    public class ProductCard
    {
        public List<Product> Items { get; }

        public ProductCard(List<Product> products)
        {
            Items = products;
        }

        /// <summary>
        /// Метод добавления продукта в продуктовую корзину
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            Items.Add(product);
        }

        public override string ToString()
        {
            return $"Items: {Items}";
        }
    }
}