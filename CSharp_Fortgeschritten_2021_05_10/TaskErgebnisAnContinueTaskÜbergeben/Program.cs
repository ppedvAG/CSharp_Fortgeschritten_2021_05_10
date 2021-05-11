using System;
using System.Threading.Tasks;

namespace TaskErgebnisAnContinueTaskÜbergeben
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variante 1
            Task<string> task = Task.Run(DayTime);
            task.ContinueWith(abc => ShowDayTime(abc.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith(task => ForErrorHandling(), TaskContinuationOptions.OnlyOnFaulted);

            Task.Run(DayTime)
                .ContinueWith(abc => ShowDayTime(abc.Result), TaskContinuationOptions.OnlyOnRanToCompletion)
                
            //Variante 2

            Task<string> task1 = Task.Run( //Aufruf einer anonymen Methode
            (/*Parameterliste*/) =>
            {
                DateTime date = DateTime.Now;
                return date.Hour > 17
                   ? "evening"
                   : date.Hour > 12
                       ? "afternoon"
                       : "morning";
            });

            Task task2 = task1.ContinueWith(
                antecedent =>
                {
                    Console.WriteLine($"Good {antecedent.Result}!");
                    Console.WriteLine($"And how are you this fine {antecedent.Result}?");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);

            task.Wait();

            Console.ReadKey();
        }


        public static string DayTime()
        {
            DateTime date =  DateTime.Now;

            return date.Hour < 17 ? "evening" : date.Hour > 12 ? "afternonn" : "morning";
        }

        public static void ShowDayTime (string result)
        {
            Console.WriteLine(result);
        }

        public static void ForErrorHandling()
        {

        }
    }
}
