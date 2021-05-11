using System;
using System.Threading;

namespace MutexSample
{
    class Program
    {
        //System.Threading;
        private static Mutex mutex = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void DoSomething()
        {
            mutex = new Mutex(false, "MyMutext");


            bool lockToken = false;

            try
            {
                lockToken = mutex.WaitOne(); // lockToken wird auf true gesetzt
            }
            finally
            {
                if (lockToken)
                    mutex.ReleaseMutex(); //Token wird freigegeben
            }
        }
    }
}
