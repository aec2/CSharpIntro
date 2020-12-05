using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class EFProductDal : IProductDal
    {

        List<Product> _products;
        public EFProductDal()
        {

            _products = new List<Product>
            {
                new Product{ProductId = 1, ProductName ="Acer EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitStock=2},
                new Product{ProductId = 2, ProductName ="Asus EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitStock=1},
                new Product{ProductId = 3, ProductName ="Hp EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitStock=0},
                new Product{ProductId = 4, ProductName ="Mac EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitStock=3},
                new Product{ProductId = 5, ProductName ="Dell EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitStock=10},
            };

        }
        public void Add(Product product)
        {
            Console.WriteLine("EntityFramework ile eklendi ");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
