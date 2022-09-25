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
            Console.WriteLine("Chouse 1 or 2 or 3");
            string a = (Console.ReadLine());
            Triangle triangle = new Triangle();
            Squear squear = new Squear();
            Rectangle rectangle = new Rectangle();
            if (a == "1")
            {
                triangle.Print();
            }
            else if (a == "2")
            {
                squear.Print();
            }
            else if (a == "3")
            {
                rectangle.Print();
            }

        }

    }
}
