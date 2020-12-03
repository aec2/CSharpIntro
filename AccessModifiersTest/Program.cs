using System;
using AccesModifiers;
namespace AccessModifiersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            House house = new House();
            house.City = "Kars";
        }
    }
}
