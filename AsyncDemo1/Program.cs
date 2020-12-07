using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo1
{
    class Program
    {
        static void Main(string[] args) //Main Thread // UI Thread
        {
            Console.WriteLine($"Main Thread no : {Thread.CurrentThread.ManagedThreadId}");

            //Task task1 = new Task(Process1);
            //task1.Start();

            //Task task1 = Task.Factory.StartNew(Process1);

            //Task task1 = Task.Run(Process1);

            //Task task1 = Task.Run(() => {
            //    Process1();
            //    Process2();

            //});

            Task task1 = Task.Run(Process1);


            task1.Wait();
            Process2();
            Console.ReadKey();
        }
        static void Process1()
        {
            Console.WriteLine("1. İşleme başladım");
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");

        }
        static void Process2()
        {
            Console.WriteLine("2. İşleme başladım");
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");

        }
    }
}
