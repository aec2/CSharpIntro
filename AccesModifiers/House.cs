using System;
using System.Collections.Generic;
using System.Text;

namespace AccesModifiers
{
    public class House
    {
        // private only in the class
        // protected in class + inhereted class
        public House()
        {
            
        }
        public int Id { get; set; }

        public string City { get; set; }

        private string Suburb { get; set; }
    }

    class HouseTest: House
    {
        public HouseTest()
        {
           
        }
    }
}
