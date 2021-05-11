using System;
using System.Threading;

using System.Threading.Tasks; //ab .NET 4.0 wurde dieses Namespace hinzugefügt

namespace _001_EasyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task easyTask = new Task(IchMacheWasImTask); //Funktionzeiger wird hier übergeben
            easyTask.Start();
            easyTask.Wait(); //Thread.Join


            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("*");
            }


            Console.ReadKey();

        }

        private static void IchMacheWasImTask()
        {
            
            for (int i = 0; i <100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("#");
            }
        }
    }
}
