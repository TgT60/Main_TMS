using System;


namespace Shape
{
    class ColorAtibute : Attribute
    {
        public ConsoleColor Color { get; set; }
        public ColorAtibute( ConsoleColor color)
        {
            Color = color;
        } 
    }
}
