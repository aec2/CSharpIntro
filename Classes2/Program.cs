using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() {ProductName="Telefon", UnitPrice=300, UnitsUnStock=43 };
     

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
