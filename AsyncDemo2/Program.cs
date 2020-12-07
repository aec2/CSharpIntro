using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo2
{
    class Program
    {
        static void Main(string[] args) //Main Thread // UI Thread
        {
            Console.WriteLine($"Main Thread başladı. {Thread.CurrentThread.ManagedThreadId}");
            Process1Async();
            Process1Async();
            Process1Async();

            Process1Async();
            Process2Async();
            Process1();
            Process2();
            Console.ReadKey();
        }
        static void Process1()
        {
            Console.WriteLine($"Senkron 1. İşleme başladı. {Thread.CurrentThread.ManagedThreadId}");
        }
        static async Task Process1Async()
        {
            await Task.Run(() =>
             {
                 Thread.Sleep(1000);
                 Console.WriteLine($"Async 1. İşleme başladı.  {Thread.CurrentThread.ManagedThreadId}");

             });
        }
        static void Process2()
        {
            Console.WriteLine($"Senkron 2. İşleme başladı. {Thread.CurrentThread.ManagedThreadId}");
        }

        static async Task Process2Async()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Async 2. İşleme başladı.  {Thread.CurrentThread.ManagedThreadId}");

            });
        }
    }
}
