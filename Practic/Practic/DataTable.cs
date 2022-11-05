using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Practic
{
    public class DataTable
    {
        public string Lable { get; set; }
        public int Sum { get; set; }
        
        public static List<DataTable> GetDeserialisedTableFromFile(string JsonData)
        {                    
            FileStream fileStream = File.Open(JsonData, FileMode.OpenOrCreate);

            StreamReader streamReader = new StreamReader(fileStream);

            JsonSerializer js = new JsonSerializer();

            var b = (List<DataTable>) js.Deserialize(streamReader, typeof (List<DataTable>));
            return b;
        }

        public static string JsonDataFileName(string JsonData)
        {
            FileStream fileStream = File.Open(JsonData, FileMode.OpenOrCreate);

            StreamReader streamReader = new StreamReader(fileStream);

            var a  = streamReader.ReadToEnd();

            fileStream.Close();
            streamReader.Close();

            return a;

        }
      
    }
}
