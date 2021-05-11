using System;

namespace DelegatesActionsFuncsSample
{


    delegate int NumbChange(int num); //Definierung eines Delegate-Typs
    delegate void NumbChange2(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            NumbChange nc1 = new NumbChange(Add12); //Vewrwende den Funktionszeige von Add12

            //int result = nc1(50);
            nc1 += Sub17;
            var result1 = nc1(50); // Add12 + Sub17
            nc1 -= Add12;
            nc1(70); //wird nur Sub17 aufgerufen

            Action a1 = new Action(VoidMethodeWithoutParams); //Action kann nur Methoden ohne Rückgabetyp aufrufen
            a1();

            NumbChange2 nc2 = new NumbChange2(AddNums);
            Action<int, int, int> a2 = AddNums;
            a2 += AddNums;
            a2(12, 33, 4); //AddNums wird 2x gecalled

            
            Func<int, int, int> rechnerFunc = Addition;
            int result2 = rechnerFunc(23, 12);

        }

        public static int Addition(int z1, int z2)
        {
            return z1 + z2;
        }

        private static int Add12(int num)
        {
            return num + 12;
        }

        private static int Sub17(int num)
        {
            return num - 17;
        }

        public static void VoidMethodeWithoutParams()
        {
            Console.WriteLine("Hello world!");
        }

        public static void AddNums(int a, int b, int c)
        {
            int result = a + b + c;

            Console.WriteLine($"{result}");
        }
    }
}
