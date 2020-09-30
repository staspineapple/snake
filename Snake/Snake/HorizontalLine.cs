using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> dots = new List<Point> { };
        public HorizontalLine(int xfirst, int xlast, int y, char sym)
        {                        
            for (int i = xfirst; i < xlast; i++)
            {
                Point point = new Point(i,y,sym);
                dots.Add(point);
            }
        }
        public void Draw()
        {
            foreach (Point p in dots)
            {
                p.Draw();
            }
        }

    }
}
