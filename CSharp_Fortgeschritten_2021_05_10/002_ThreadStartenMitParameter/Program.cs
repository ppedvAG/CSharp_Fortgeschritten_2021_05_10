using System;
using System.Threading;

namespace _002_ThreadStartenMitParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart parameterizedThread = new ParameterizedThreadStart(MacheEtwasInEinemThread);

            Thread thread = new Thread(parameterizedThread);
            thread.Start(123);
            thread.Join();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("*");
            }

            Console.ReadLine();
        }

        private static void MacheEtwasInEinemThread(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.Write("#");
            }
        }
    }
}
