using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practic
{
    public class Item
    {
        public int T_Shorts { get; set; }
        public int Boots { get; set; }
        public string Brand { get; set; }

        public Item()
        {
            T_Shorts = 4;
            Boots = 8;
            Brand = "Nike";
        }
        public void Post()
        {
            T_Shorts = 10;
            Boots = 20;
            Brand = "Adidas";

        }


    }
}
