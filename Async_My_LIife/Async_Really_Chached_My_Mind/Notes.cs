﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Async_Really_Chached_My_Mind
{
    class Notes
    {
        public void MakeNotesAboutWork()
        {
            Thread.Sleep(10000);

            Console.WriteLine("Remember all work 15");

            Console.WriteLine("Write all work on Notebook 16");
        }
    }
}
