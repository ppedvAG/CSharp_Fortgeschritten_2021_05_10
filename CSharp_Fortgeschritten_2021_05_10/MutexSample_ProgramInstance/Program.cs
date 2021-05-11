﻿using System;
using System.Threading;

namespace MutexSample_ProgramInstance
{
    class Program
    {
        static Mutex _mutex;

        static void Main(string[] args)
        {
            if (!Program.IsSingleInstance())
            {
                Console.WriteLine("More than one instance");
            }
            else
                Console.WriteLine("one Instance");

            Console.ReadLine();
        }

        static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("ABC");
            }
            catch
            { 
                Program._mutex = new Mutex(true, "ABC");
                return true;
            }
            return false;
        }
    }
}
