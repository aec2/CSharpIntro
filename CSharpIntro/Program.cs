using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double aboneSayisi = 34.00;
            int yas = 25;
            String name = "Abdullah Enes Can";
            bool deger = true;
            double piyasaDun = 1150000.6;
            double piyasaBugun = 1160000;

            bool sonuc = piyasaBugun > piyasaDun;
            string mesajArtis = "Artış gerçekleşti";
            string mesajAzalis = "Azalış gerçekleşti";
            Console.WriteLine((piyasaBugun > piyasaDun) ? mesajArtis : mesajAzalis);

        }
    }
}
