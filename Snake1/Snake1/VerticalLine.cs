using System;
using System.Collections.Generic;
using System.Text;

namespace Snake1
{

    class VerticalLine : Figure
    {
        

        public VerticalLine(int yTop, int yBottom, int x, char symb)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }
           
    }

}



    


