using System;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer();

            House house = new House();
            house.City = "Kayseri";
            house.Id = 0;
            

        }
    }
    class Customer
    {
        // classların modifier'ı default olarak 'internal'
        // yani aynı namespace altında erişilebilirlik sağlar
    }
}
