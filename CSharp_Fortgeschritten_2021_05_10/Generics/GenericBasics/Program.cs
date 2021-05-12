using System;
using System.Collections.Generic;


namespace GenericBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> str = new List<string>();
            List<string> str1 = new List<string>();

            IDictionary<Guid, string> dict = new Dictionary<Guid, string>();
            dict.Add(Guid.NewGuid(), "123453dfgsdfg");
            dict.Add(Guid.NewGuid(), "123453dfgsdfg");
            dict.Add(Guid.NewGuid(), "123453dfgsdfg");

            dict.Add(new KeyValuePair<Guid, string>(Guid.NewGuid(), "abcdefgh"));

            foreach (KeyValuePair<Guid, string> currenEntry in dict)
            {
                Console.WriteLine(currenEntry.Key.ToString());
                Console.WriteLine(currenEntry.Value);
            }

            DataStore<Guid> data = new DataStore<Guid>();
            data.AddOrUpdate(1, Guid.NewGuid());

            DataStore<int> data1 = new DataStore<int>();
            data.DisplayDefault<DateTime>();
        }
    }

    public class DataStore<T>
    {
        private T[] _data = new T[10];

        public T[] Data
        {
            get => _data;
            set => _data = value;
        }

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        public void DisplayDefault<DD>()
        {
            DD item = default(DD);

            Console.WriteLine($"Default value of {typeof(DD)} is {(item == null ? "null" : item.ToString())}.");
        }
    }


































































    public abstract class HariboBaseClass
    {
        public abstract IList<Haribo> FindHaribos();

        public abstract IEnumerable<Haribo> FindHaribosReadOnly();
    }

    public class Haribo
    {
    }
}
