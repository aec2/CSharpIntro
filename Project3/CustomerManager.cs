using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Enes",LastName="Can",City="Kocaeli", Email="aenesc1@"},
                new Customer{Id=2, FirstName="Salim",LastName="Aksoy",City="Ankara", Email="Salim@"},
                new Customer{Id=3, FirstName="Furkan",LastName="Aksoy",City="Ankara", Email="dasda@"},
                new Customer{Id=4, FirstName="Cagdas",LastName="Gül",City="Kocaeli", Email="eqewq@"},
                new Customer{Id=5, FirstName="Mert",LastName="Taze",City="İstanbul", Email="mert@"},
            };
        }
        List<Customer> customers;
        public List<Customer> GetAll()
        {
            //Veritabanına bağlan


            return customers;
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
