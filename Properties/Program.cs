using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            Console.WriteLine(product.Id);
            product.UnitsInStock = 50;
            Console.WriteLine(product.UnitsInStock);
            product.UnitPrice = 500;
            Console.WriteLine(product.UnitPrice);

        }
    }

    class Product
    {
        //field
        decimal _unitPrice;

        // auto implemented property
        public int Id { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice
        {
            get { return _unitPrice + _unitPrice*18/100; }
            set { _unitPrice = value; }
        }

        public decimal UnitsInStock;

        //propfull

    }
}
