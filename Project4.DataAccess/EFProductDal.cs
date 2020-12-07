using Microsoft.EntityFrameworkCore;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EFProductDal : IProductDal
    {

        List<Product> _products;
        public EFProductDal()
        {

            //_products = new List<Product>
            //{
            //    new Product{ProductId = 1, ProductName ="Acer EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitsInStock=2},
            //    new Product{ProductId = 2, ProductName ="Asus EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitsInStock=1},
            //    new Product{ProductId = 3, ProductName ="Hp EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitsInStock=0},
            //    new Product{ProductId = 4, ProductName ="Mac EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitsInStock=3},
            //    new Product{ProductId = 5, ProductName ="Dell EF Bilgisayar", QuantityPerUnit="32 Gb Ram", UnitPrice=10000, UnitsInStock=10},
            //};

        }
        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges(); // transaction

            }
        }

        public async Task AddAsync(Product product)
        {
            NorthwindContext context = new NorthwindContext();

            await context.Products.AddAsync(product);
            await context.SaveChangesAsync(); // transaction


        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                context.SaveChanges(); // transaction
            }
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            // garbage collectoru bekleme, bittiği and despose et
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Task<List<Product>> GetAllAsync()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //  Eğer birden fazla data dönerse hata verir.
                return context.Products.SingleOrDefault(p => p.ProductId == id);

            }
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryId = product.CategoryId;

                context.SaveChanges(); // transaction
            }
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
