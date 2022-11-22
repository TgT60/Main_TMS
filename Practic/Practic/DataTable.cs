using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Practic
{
    public class DataTable
    {           
        public static List<DataTable> GetDeserialisedTableFromFile(string fileName)
        {                    
            FileStream fileStream = File.Open(fileName , FileMode.OpenOrCreate);

            StreamReader streamReader = new StreamReader(fileStream);

            JsonSerializer js = new JsonSerializer();

            var b = (List<DataTable>) js.Deserialize(streamReader, typeof (List<DataTable>));
            return b;
        }

        public static string JsonDataFileName(string fileName)
        {
            FileStream fileStream = File.Open(fileName , FileMode.OpenOrCreate);

            StreamReader streamReader = new StreamReader(fileStream);

            var a  = streamReader.ReadToEnd();

            fileStream.Close();
            streamReader.Close();

            return a;
        }
      
    }
}
