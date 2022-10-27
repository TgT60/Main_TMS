using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebAPI
{
    public class Person
    {
        public List<string> Name { get; set; }
        public List<int> Id { get; set; }
        public List<string> Street { get; set; }
        public List<string> State { get; set; }
        public List<string> Country { get; set; }
        public Person()
        {
            Name = new List<string>();
            Id = new List<int>();
            Country = new List<string>();
            State = new List<string>();
            Street = new List<string>();
        }

        public void AddRow(string name, int id, string street, string state, string country)
        {
            Name.Add(name);
            Id.Add(id);
            Country.Add(country);
            Street.Add(street);
            State.Add(state);
        }

        public void Print()
        {
            for (int i = 0; i < Name.Count; i++)
            {
                Console.WriteLine($"{Name[i]}\t {Id[i]}\t {Country[i]}\t {Street[i]}\t {State[i]}");
            }
        }

        public void MakePersonTable()
        {

            AddRow("Ivan", 23, "Gromva", "Minsk", "Belarus");
            AddRow("Gorg", 53, "LogS", "Minsk", "Belarus");
            AddRow("Bruck", 44, "Grep", "Minsk", "Belarus");
            AddRow("Nami", 93, "Frung", "Minsk", "Belarus");
            AddRow("Drake", 143, "Jorka", "Minsk", "Belarus");
        }
        public void JsonS()
        { 
            MakePersonTable();

            FileStream file = System.IO.File.Open("Table1.txt", FileMode.OpenOrCreate);

            StreamWriter streamWriter = new StreamWriter(file);
            JsonSerializer js = new JsonSerializer();

            js.Serialize(streamWriter, $"{Name} \n {Id}\n {Country}\n {Street}\n {State}");

            streamWriter.Close();
            file.Close();

        }
       
    }
}