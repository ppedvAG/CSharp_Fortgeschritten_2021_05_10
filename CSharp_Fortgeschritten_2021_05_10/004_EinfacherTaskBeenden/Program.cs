using System;
using System.Threading;
using System.Threading.Tasks;

namespace _004_EinfacherTaskBeenden
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Threading;
            CancellationTokenSource cts = new CancellationTokenSource();

            Task task = Task.Factory.StartNew(MeineMethodeMitAbbrechen, cts);

            cts.Cancel(); //Signal zum Abbrechen
        }

        private static void MeineMethodeMitAbbrechen(object param) //object param bekommt den CancellationTokenSource
        {
            CancellationTokenSource source = (CancellationTokenSource)param;

            while (true)
            {
                Console.WriteLine("zzzz.zzzzz....zz");
                Thread.Sleep(50);


                if (source.IsCancellationRequested)
                    break;
            }

        }
    }
}
