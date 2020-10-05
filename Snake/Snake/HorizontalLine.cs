using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine:   Figure
    {
        
        public HorizontalLine(int xfirst, int xlast, int y, char sym)
        {
            dots = new List<Point>();
            for (int i = xfirst; i < xlast; i++)
            {
                Point point = new Point(i,y,sym);
                dots.Add(point);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;



            foreach (Point p in dots)
            {
                p.Draw();
            }
            // base.Draw();

            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
