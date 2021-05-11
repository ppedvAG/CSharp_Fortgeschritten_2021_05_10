using System;
using System.Threading;

namespace _001_ThreadStarten
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Threading
            Thread thread = new Thread(MacheEtwasInEinemThread); //Funktionszeiger wird übergeben 
            
            thread.Start(); //Thread startet

            thread.Join(); //Warte bis Thread fertig ist. 
            

            for (int i = 0; i < 100; i++)
                Console.Write("*");


            Console.ReadLine();
        }

        private static void MacheEtwasInEinemThread()
        {
            for (int i = 0;i < 100; i++)
                Console.Write("#");
        }
    }



}
