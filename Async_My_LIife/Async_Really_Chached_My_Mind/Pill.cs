using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Really_Chached_My_Mind
{
    class Pill
    {
        public async void DrinkPill()
        {
            Console.WriteLine("Pour in coup water 9");

            Console.WriteLine("Put Pill un coup 10");
            await Task.Delay(3000);

            Console.WriteLine("Drink potion 11");
        }
    }
}
