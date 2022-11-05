using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async_My_LIife
{
      class Pill
    {

        public  void DrinkPill()
        {
            Console.WriteLine("Pour in coup water");

            Console.WriteLine("Put Pill un coup");
            Thread.Sleep(3000);

            Console.WriteLine("Drink potion\n");
        
        }            
    }
}
