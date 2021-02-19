using System;
using System.Collections.Generic;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw(); 

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(0, 40, 20, '+');
            line.Draw();

            VerticalLine line1 = new VerticalLine(0, 20, 40, '-');
            line1.Draw();

            Console.ReadLine();
        }
    }
}
