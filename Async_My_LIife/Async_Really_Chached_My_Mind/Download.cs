using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Really_Chached_My_Mind
{
    class  Download
    {
        public async Task<Soft> DowloadNewApp()
        {
            Console.WriteLine("Find new soft from work 12");

            Console.WriteLine("Download new app 13");
            await Task.Delay(3000);

            Console.WriteLine("Check new app 14");

            return new Soft();
        }

    }
}
