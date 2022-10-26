using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Dima", 11, "Gromova", "Nebraska", "Minsk");
            FileStream fileStream = File.Open("Table.txt", FileMode.OpenOrCreate);
            //fileStream.Flush();
            StreamWriter streamWriter = new StreamWriter(fileStream);
            JsonSerializer js = new JsonSerializer();
            js.Serialize(streamWriter, js);
            var jsonString = JsonConvert.SerializeObject(person);
            Console.WriteLine(jsonString);
            var deObj = JsonConvert.DeserializeObject(jsonString);
            //Console.WriteLine(deObj);
            streamWriter.Close();
            fileStream.Close();
           
        }
    }
}
