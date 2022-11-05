using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Practic.Controllers
{
    [ApiController]
    [Route("DataFile")]
    public class DataController : ControllerBase
    {
        public readonly IConfiguration _configure;
        public readonly string _name;
        public DataController(IConfiguration config)
        {
            _configure = config;
            _name = _configure.GetValue<string>("DataFile:Data");
        }

        [HttpGet("DataFile")]
        public string GetJsonData()
        {
            return _name;
        }

        [HttpGet("TableData")]
        public string GetTable()
        {
            return DataTable.JsonDataFileName(_name);
        }

        [HttpGet("TableData-Json")]
        public List<DataTable> GetJson()
        {
            return DataTable.GetDeserialisedTableFromFile(_name);
        }

        [HttpGet("Item")]
        public Item GiveAll()
        {
            var a = new Item();
            return a;
        }

        [HttpGet("Item{Brand}")]
        public Item GiveAll2()
        {
            var a = new Item();
            return a;
        }

        [HttpPost("Item")]
        public Item PutAll()
        {
            var b = new Item();
            
            b.Post();

            return b;

        }
    }

}
