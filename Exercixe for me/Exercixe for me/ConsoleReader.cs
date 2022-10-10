using System;
using System.Collections.Generic;
using System.Text;

namespace Exercixe_for_me
{
   
    class ConsoleReader
    {
        public delegate ConsoleKey MethodContainer();
        public delegate void Exit();
        public event MethodContainer KeyPressed;
        public event Exit ExitKeyPressed;

        public void logic()
        {                
            KeyHandler console2 = new KeyHandler();
            
            KeyPressed += console2.Enter;
            ExitKeyPressed += console2.Exit;

            while (true)
            {
                if (KeyPressed() == ConsoleKey.X)
                {
                    Console.WriteLine("   Work");
                    ExitKeyPressed();
                }
                else
                {
                    Console.WriteLine("   Don't work");         
                }
            }
        }


    }
}
