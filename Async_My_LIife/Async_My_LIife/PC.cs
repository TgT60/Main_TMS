using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async_My_LIife
{
    public class PC
    {
        public void SitOnPc()
        {
            Console.WriteLine("Sit down on pc");

            Console.WriteLine("Turn on pc\n");
            Thread.Sleep(3000);

        }

    }
}
