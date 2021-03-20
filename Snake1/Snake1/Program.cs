using System;
using System.Collections.Generic;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(81, 26);
            Console.SetBufferSize(81, 26);


            HorizontalLine Upline = new HorizontalLine(0, 80, 0, '+');
            Upline.Draw();

            HorizontalLine Downline = new HorizontalLine(0, 80, 25, '+');
            Downline.Draw();

            VerticalLine Rightline = new VerticalLine(0, 25, 0, '-');
            Rightline.Draw();


            VerticalLine Leftline = new VerticalLine(0, 25, 80, '-');
            Leftline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
