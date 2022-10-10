using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    abstract class Figure
    {
        delegate void Repite(string text);
        event Repite Notify;
        public abstract void Print();          
    }
}
