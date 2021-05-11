using System;
using System.Threading;

namespace ThreadPoolSample
{
    class Program
    {

        //Weitere beispiele zu Threads -> https://docs.microsoft.com/de-de/dotnet/standard/threading/cancellation-in-managed-threads
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Methode1);
            ThreadPool.QueueUserWorkItem(Methode2);
            ThreadPool.QueueUserWorkItem(Methode3);

            

            Console.ReadKey();
        }

        static void Methode1(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.WriteLine("#");
            }
        }

        static void Methode2(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.WriteLine("-");
            }
        }

        static void Methode3(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.WriteLine("*");
            }
        }
    }
}
