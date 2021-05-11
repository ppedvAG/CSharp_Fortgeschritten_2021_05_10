using System;
using System.Threading;

namespace MonitorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void KritischerCodeAbschnitt()
        {
            int x = 1;

            Monitor.Enter(x);
            //Hier darf nur ein Thread rein
            try
            {
                //Mach was
            }
            finally
            {
                Monitor.Exit(0);
            }
        }
    }
}
