using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kredi1 = "Hızlı kredi1";
            //string kredi2 = "Maaşını Halkbank'tan Alanlara Özel";
            
            //Console.WriteLine(kredi1);
            //Console.WriteLine(kredi2);

            int[] sayilar = new int[3];

            sayilar[0] = 32;
            sayilar[1] = 6;
            sayilar[2] = 452;

            Console.WriteLine($"En büyük sayı: {sayilar[2]}");
            Console.WriteLine($"Ortanca sayı: {sayilar[0]}");
            Console.WriteLine($"En küçük sayı: {sayilar[1]}");

        }
    }
}
