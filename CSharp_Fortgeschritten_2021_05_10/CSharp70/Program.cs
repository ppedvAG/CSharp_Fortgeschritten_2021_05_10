using System;

namespace CSharp70
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Out-Variable //Out - In - Ref 

            string str = "12345";
            int myConvertedNumber;


            //TryParse -> str und kopiert in myConvertedNumber (Zuweisung, intern) 
            if (int.TryParse(str, out myConvertedNumber ))
            {
                //hier ist myConvertedNumber konventiert 
                Console.WriteLine(myConvertedNumber* myConvertedNumber);
            }

            #endregion

            #region Pattern-Matching
            CheckObject(123);
            CheckObject("123");
            #endregion


            #region Tupel

            Person p = new Person("Peter", "Muster", "Mustermann");
            var name = p.VollenNamenAusgabe();
            var name1 = p.VollenNAmenAusgabeB();


            Console.WriteLine($"{name.Item1}  {name.Item2} {name.Item3}");

            Console.WriteLine($"{name1.Vorname}  {name1.ZweiterVorname} {name1.Nachname}");
            #endregion


            #region Return-Reference
            int[] zahlen = { 5, 7, 434, 85, 2_3, 777, -12 }; //23 wird zu 100_000_000;


            //ERhalte die Speicheradresse von zahl[n] 
            ref int position = ref Zahlensuche(23, zahlen);

            //Durch die Speicheradresse wird das Zahlen-Array manipuliert.
            position = 100_000_000;

            Console.WriteLine(zahlen[5]);
            #endregion
        }

        public static void CheckObject(object obj)
        {
            // if obj == null
            if (obj is null)
                Console.WriteLine("Object obj is null");


            if (obj is string s)
            {
                Console.WriteLine(s.ToUpper());
            }

            if (obj is int i)
            {
                Console.WriteLine(i * i);
            }
        }

        static ref int Zahlensuche(int gesuchteZahl, int[] zahlen)
        {
            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] == gesuchteZahl)
                    return ref zahlen[i];
            }

            throw new IndexOutOfRangeException();
        }
    }


    public class Person
    {
        public string Vorname { get; set; }
        public string ZweiterVorname { get; set; }
        public string Nachname { get; set; }


        //ctor -> tab + tab -> Konstruktur
        public Person(string vorname, string zweiterVortname, string nachname)
        {
            Vorname = vorname;
            ZweiterVorname = zweiterVortname;
            Nachname = nachname;
        }

        public (string, string, string) VollenNamenAusgabe()
        {
            return (Vorname, !string.IsNullOrEmpty(ZweiterVorname) ? ZweiterVorname : string.Empty, Nachname);
        }

        public (string Vorname, string ZweiterVorname, string Nachname) VollenNAmenAusgabeB()
        {
            return (Vorname, !string.IsNullOrEmpty(ZweiterVorname) ? ZweiterVorname : string.Empty, Nachname);
        }
    }
}
