using System;
using System.Collections.Generic;
using System.Text;
using Project4.DataAccess;
using Project4.Entities;

namespace Project4.Business
{
    public class ProductManager: IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName == "Laptop")
            {
                throw new DuplicateProductException("LAPTOP EKLEYEMEZSINIZ!");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {

            // İş kodları buraya...

            return _productDal.GetAll();
        }
    }
}
