using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class DuplicateProductException: Exception
    {   
        // base, exception'ın da constructor'ını çalıştır demek.
        public DuplicateProductException(string message): base(message)
        {
             
        }
    }
}
