using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async_My_LIife
{
    class App
    { 
        public void WorkWithApp() 
        {
            Console.WriteLine("Open app");
            Thread.Sleep(3000);

            Console.WriteLine("App loading");
            Thread.Sleep(3000);

            Console.WriteLine("App Start loading textures");
            Thread.Sleep(3000);

            Console.WriteLine("Make changes");
            Console.WriteLine("Close app\n");
        } 
    }
}
