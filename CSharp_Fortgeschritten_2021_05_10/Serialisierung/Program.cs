using Newtonsoft.Json;
using System;
using System.IO; //Stream
using System.Runtime.Serialization.Formatters.Binary; //BinaryFormatter
using System.Threading.Tasks;
using System.Xml.Serialization;

using Serialisierung.CSV;

namespace Serialisierung
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kursus zu decimal

            //decimal steht für Geldbeträge und ist juristisch von Microsoft abgesichert. 
            decimal moneyValue = 155m;
            float floatnumber = 1323.4f;

            Person person = new Person
            {
                Vorname = "Max",
                Nachname = "Mustermann",
                Alter = 64,
                Kontostand = 100_000
            };

            #region Binären Serialisierung
            Stream stream = null;
            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //Stream stream = File.OpenWrite("Person.bin");
            //binaryFormatter.Serialize(stream, person);
            //stream.Close();
            #endregion

            #region Binär-Datei einlesen
            //stream = File.OpenRead("Person.bin");
            //Person geladedePerson = (Person)binaryFormatter.Deserialize(stream);
            //stream.Close();
            #endregion

            #region XML schreiben
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            stream = File.OpenWrite("Person.xml");
            xmlSerializer.Serialize(stream, person);
            stream.Close();
            #endregion

            #region XML lesen
            stream = File.OpenRead("Person.xml");
            Person geladenePersonViaXML = (Person)xmlSerializer.Deserialize(stream);
            #endregion


            string jsonString = JsonConvert.SerializeObject(person);
            Task task = File.WriteAllTextAsync("Person.json", jsonString);
            task.Wait();
            Person jsonPerson = JsonConvert.DeserializeObject<Person>(jsonString);


            person.Serialize("Person.csv");

            Person newPerson = new Person();
            newPerson.Deserialize("Person.csv");
        }
    }

    //[Serializable]
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get;set;}

        /*[NonSerialized()]*/ //bei binär und JSON
        public decimal Kontostand;
    }
}
