using System;
using System.Collections.Generic;
using System.Text;

namespace Exercixe_for_me
{
    
    class KeyHandler
    {    
        public ConsoleKey Enter()
        {          
            ConsoleKey a = Console.ReadKey().Key;
            return a;
        }
        public void  Exit()
        {
            Environment.Exit(0);
        }
    }
}
