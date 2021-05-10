using System;

namespace CSharp90
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonObj obj1 = new PersonObj(123, "Max", "Muster");
            PersonObj obj2 = new PersonObj(123, "Max", "Muster");

            if (obj1 == obj2)
            {
                Console.WriteLine("Wahr"); //wird ausgeführt
            }
            else
            {
                Console.WriteLine("Falsch");
            }

            if (obj1.Equals(obj2))
            {
                Console.WriteLine("Wahr");
            }
            else
            {
                Console.WriteLine("Falsch"); //wird ausgeführt
            }


            Person person1 = new Person(1, "Max", "Mustermann");
            Person person2 = new Person(1, "Max", "Mustermann");

            //Tuple 
            var deconstrukct = person1;
            


            if (person1 == person2)
            {
                Console.WriteLine("Wahr");
            }
            else
            {
                Console.WriteLine("Falsch"); //wird ausgeführt
            }
            
            if (person1.Equals(person2))
            {
                Console.WriteLine("Wahr"); //wird ausgeführt
            }
            else
            {
                Console.WriteLine("Falsch");
            }
        }
    }

    public record Person (int Id, string Vorname, string Nachname); //Kompakte Schreibweise

    public record Person2 
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }


        public string HariboString()
        {
            return "ABC";
        }
    }


    public class PersonObj
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public PersonObj(int id, string vorname, string nachname)
        {
            this.Id = id;
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);    
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }
    }

}
