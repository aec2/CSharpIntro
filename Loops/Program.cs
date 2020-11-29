using System;
using System.Collections.Generic;
using System.Linq;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.arkadasSayiKontrol(220, 284);
            myProgram.arkadasSayiKontrol(17296, 18416);
            
        }
        public void arkadasSayiKontrol(int x, int y)
        {
            int count1 = 1;
            int count2 = 1;
            var bolenSayilar1 = new List<int>();
            var bolenSayilar2 = new List<int>();

            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    bolenSayilar1.Add(i);
                }
            }

            for (int i = 1; i < y; i++)
            {
                if (y % i == 0)
                {
                    bolenSayilar2.Add(i);
                }
            }

            Console.WriteLine("X elemanları -->" + string.Join(", ", bolenSayilar1));
            Console.WriteLine("Y elemanları -->" + string.Join(", ", bolenSayilar2));

            int xTotal = bolenSayilar1.Sum();
            int yTotal = bolenSayilar2.Sum();

            Console.WriteLine($"xTotal: {xTotal} and yTotal: {yTotal}");
            string result = (xTotal == y && yTotal == x ? $"{x} ve {y} arkadaş sayılar." : $"{x} ve {y} arkadaş sayı değiller.");

            Console.WriteLine(result);
        }
    }
}
