﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambdaSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>()
            {
                new Person { Id=1, Age=40, Vorname="Kevin", Nachname="Winter"},
                new Person { Id=2, Age=43, Vorname="Petra", Nachname="Musterfrau"},
                new Person { Id=3, Age=19, Vorname="Pascal", Nachname="Neugierig"},
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ (PagingNumber(2) + PagingSize(3))
                new Person { Id=4, Age=53, Vorname="Matthias", Nachname="Trump"},
                new Person { Id=4, Age=53, Vorname="Matthias2", Nachname="Trump2"},
                new Person { Id=5, Age=23, Vorname="Denise", Nachname="Muster"},
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                new Person { Id=6, Age=39, Vorname="Steffi", Nachname="Schuhmacher"},
                new Person { Id=7, Age=41, Vorname="Heike", Nachname="Müller"},
                new Person { Id=8, Age=29, Vorname="Peter", Nachname="Mustermann"}
            };

            //hat die Liste Datensätze
            if (persons.Any())
            {

            }


            // Alle Personen ab 30 werden in result1 ermittelt. 

            //Linq-Methoden: Where / OrderBy / Single / Max / 
            //Lambda Expression: select => select.Age >= 30
            IList<Person> result1 = persons.Where(select => select.Age >= 30).ToList();

            IList<Person> result2 = persons.Where(select => select.Age >= 30)
                                           .OrderBy(select => select.Nachname)
                                           .ToList();

            Person currentPerson = persons.Single(select => select.Id == 1);




            //Alte Variante

            IList<Person> result3 = (from p in persons
                                     where p.Age < 40 && p.Age >= 30
                                     orderby p.Nachname
                                     select p).ToList();


            int pagingNumber = 1; //Auf welcher Pagging-Seite bin ich? 
            int pagingSize = 3; //Wieviele Elemente werden auf einer Page angezeigt. 

            IList<Person> ergebnisSeite1 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();
            
            //Hier blättern zu nächsten "Seite" 
            pagingNumber = 2;
            IList<Person> ergebnisSeite2 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();

            //Hier blättern zu nächsten "Seite" 
            pagingNumber = 3;
            IList<Person> ergebnisSeite3 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

    }
}
