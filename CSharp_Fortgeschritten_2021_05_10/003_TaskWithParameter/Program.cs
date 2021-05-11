using System;
using System.Threading.Tasks;

namespace _003_TaskWithParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze katze = new();


            //Task<string> string ist der Rückgabewert
            Task<string> task1 = Task.Factory.StartNew(MachEtwas, katze);
           
            Task<string> task2 = Task.Run<string>(() => MachEtwas(katze));

            Task<string> easyTask = new Task<string(() => MachEtwas(katze));
            easyTask.Start();

            task1.Wait();
            task2.Wait();
            easyTask.Wait();

            Console.WriteLine(easyTask.Result);





            //Beispiel 2

            Task<DayOfWeek> taskA = Task.Run(() => DateTime.Today.DayOfWeek); // ()=> ist eine anonyme Methode
            taskA.Wait();

            taskA.ContinueWith(antecedent => Console.WriteLine($"Today is {antecedent.Result}.")); //taskA.Result




        }

        private static string MachEtwas(object input)
        {
            Katze katze = null;

            if (input is Katze)
                katze = (Katze)input;

            Console.WriteLine(katze.Name);

            return DateTime.Now.ToLongDateString();
        }


        public static DayOfWeek WhatDayIsToday()
        {
            return DateTime.Today.DayOfWeek;
        }
    }


    public class Katze
    {
        public string Name { get; set; } = "Maya";
    }
}
