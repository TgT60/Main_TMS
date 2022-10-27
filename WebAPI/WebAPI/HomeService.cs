using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class HomeService : IHomeService
    {
        public string SaySomeThing()
        {
            return "Hellow"; 
        }
    }
    public interface IHomeService
    {
        string SaySomeThing();
    }
}
