using System;

namespace CSharp71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Print<int>(123);
            Print<string>("Hallo Welt");
            Print<DateTime>(DateTime.Now);
        }

        static void Print<T>(T input)
        {
            switch (input)
            {
                case int i:
                    Console.WriteLine($"Inputwert ist ein Integer: {i}");
                    break;
                case string str:
                    Console.WriteLine($"Inputwert ist ein Integer: {str}");
                    break;
                case DateTime dat:
                    Console.WriteLine($"Inputwert ist ein Integer: {dat.ToString()}");
                    break;
                default:
                    Console.WriteLine($"Typ konnte nicht gefunden werden");
                    break;
            }
        }
    }
}
