using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return DataTable.GetTextFromFile(_name);

        }

        [HttpGet("TableData_Json")]
        public List<DataTable> GetJson()
        {
            return DataTable.CreateTableWithOutSerialize(_name);

        }

    }

}
