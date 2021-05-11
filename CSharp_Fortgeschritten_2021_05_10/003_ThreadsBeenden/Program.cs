using System;
using System.Threading;

namespace _003_ThreadBeenden
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MachEtwas);
            t.Start();

            Thread.Sleep(6000);
            //t.Abort();
            t.Interrupt();
            Console.WriteLine("Thread wurde beendet");
        }


        private static void MachEtwas()
        {
            try
            {
                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("zzZzzZZzzZ");
                }
            }
            catch (AggregateException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
