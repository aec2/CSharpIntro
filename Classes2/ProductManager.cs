using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"Ürün eklendi: {product.ProductName}, {product.UnitPrice} TL, {product.UnitsUnStock} adet mevcut");
        }
    }
}
