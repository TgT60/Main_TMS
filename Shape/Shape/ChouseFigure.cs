using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class ChouseFigure 
    {
        public void Chouse()
        {
            int i = 0;
            do
            {
                Console.SetCursorPosition(0,0);
                Console.Write("Chouse 1 or 2 or 3 or 4  ");
                string a = (Console.ReadLine());
                Text text = new Text();
                Figure figure = null;
                if (a == "1")
                {
                    figure = new Triangle();
                }
                else if (a == "2")
                {
                    figure = new Squear();
                }
                else if (a == "3")
                {
                    figure = new Rectangle();
                }
                else if (a == "4")
                {
                    text.EnterText();
                }
                figure.Print();
                Console.WriteLine("Do you want to draw same figure");
               
                string b = Console.ReadLine();
                if (b == "y")
                {
                    i = 1;
                }
                else if (b == "n")
                {
                    i = 3;
                }

            }
            while (i<2);

    

            
        }
    }
}
