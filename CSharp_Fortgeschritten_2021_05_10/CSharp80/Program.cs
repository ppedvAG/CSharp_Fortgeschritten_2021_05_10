using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp80
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\Temp";
            string sequencenInString = "Hallo \t liebe \t Teilnehmer";

            string pathB = @"C:\Windows\Temp";
            

            string variablenausgabeInString = $"{DateTime.Now}";
        }


        //Diese Methode liefert ein Ergebnis-Stream aus.
        public static async IAsyncEnumerable<int> GenerierteZahlen()
        {
            for (int i = 0; i < 20; i++) //shortcut: for + tab + tab 
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public static async Task GebeZahlenAus()
        {
            await foreach (var zahl in GenerierteZahlen())
                Console.WriteLine(zahl);
        }
    }
}
