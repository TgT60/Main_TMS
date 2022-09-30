using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ChouseFigure chouseFigure = new ChouseFigure();
                chouseFigure.Chouse();
                //var obj = new Squear();
                //var attribute = obj.GetType().GetCustomAttributes(false);
                //bool attPruve = false;
                //foreach ( var att  in attribute)
                //{
                //    if (att is Squear squear)
                //    {
                //        attPruve = true;
                //    }

                //}
                //Console.WriteLine(attPruve);
            }
        }
    }
}
