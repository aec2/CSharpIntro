using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            int sonuc1 = matematik.Topla(3, 5);
            int sonuc2 = matematik.Topla(2,32);  
            int sonuc3 = matematik.Topla(sayi2:65, sayi1:10);
            int sonuc4 = matematik.ToplaParams(4,23,13,1,313,13,16,6,2);
            int sonuc5 = matematik.ToplaParams(new int[] {5,6,2,3});

            Console.WriteLine($"sonuc4: {sonuc4} sonuc5: {sonuc5}");
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }        
        
        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2+ sayi3;
        }

        public int ToplaParams(params int[] sayilar)
        {
            //int sonuc = 0;
            //foreach (var sayi in sayilar)
            //{
            //    sonuc += sayi;
            //}
            return sayilar.Sum();
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
