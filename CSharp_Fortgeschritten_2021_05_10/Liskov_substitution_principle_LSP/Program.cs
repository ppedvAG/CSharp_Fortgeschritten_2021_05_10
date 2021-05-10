using System;

namespace Liskov_substitution_principle_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public virtual string CompleteName()
        {
            return Nachname + " " + Vorname;
        }
    }

    public class EmployeePerson : Person
    {
        //public override string CompleteName()
        //{
        //    return base.CompleteName();
        //}


        //public override string CompleteName()
        //{
        //    return "Nachname: " + Nachname + "Vorname: " + Vorname; 
        //}

        public override string CompleteName()
        {
            string complete = base.CompleteName();
            return string.Empty;
        }
    }
}
