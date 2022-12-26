using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Really_Chached_My_Mind
{
    class App
    { 
        public async Task<Texture> WorkWithApp() 
        {
            Console.WriteLine("Open app 4");
            await Task.Delay(3000);

            Console.WriteLine("App loading 5");
            await Task.Delay(3000);

            Console.WriteLine("App Start loading textures 6");
            await Task.Delay(3000);

            Console.WriteLine("Make changes 7 ");
            Console.WriteLine("Close app 8");

            return new Texture();
        } 
    }
}
