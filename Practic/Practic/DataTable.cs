using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Practic
{
    public class DataTable
    {
        public string Lable { get; set; }
        public int Sum { get; set; }

        public DataTable(string lable, int sum)
        {
            Lable = lable;
            Sum = sum;

        }

        public static List<DataTable> CreateTableWithOutSerialize(string name)
        {                    
            FileStream fileStream = File.Open(name, FileMode.OpenOrCreate);

            StreamReader streamReader = new StreamReader(fileStream);

            JsonSerializer js = new JsonSerializer();

            var b = (List<DataTable>) js.Deserialize(streamReader, typeof (List<DataTable>));
            return b;

        }
        public static string GetTextFromFile(string JsonData)
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
