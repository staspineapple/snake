using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine: Figure
    {
        
        public VerticalLine(int yfirst, int ylast, int x, char sym)
        {
            dots = new List<Point>();
            for (int i = yfirst; i < ylast; i++)
            {
                Point point = new Point(x, i, sym);
                dots.Add(point);
            }
        }
       

    }
}

