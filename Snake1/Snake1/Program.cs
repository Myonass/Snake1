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

            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            Upline.Draw();

            HorizontalLine Downline = new HorizontalLine(0, 78, 25, '+');
            Downline.Draw();

            VerticalLine Rightline = new VerticalLine(0, 24, 0, '-');
            Rightline.Draw();


            VerticalLine Leftline = new VerticalLine(0, 25, 79, '-');
            Leftline.Draw();

            Console.ReadLine();
        }
    }
}
