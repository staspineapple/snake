using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> border;

        public Walls()
        { 
            border = new List<Figure>();
            HorizontalLine up = new HorizontalLine(0, 75, 0, '$');
            HorizontalLine down = new HorizontalLine(0, 75, 25, '$');
            VerticalLine left = new VerticalLine(1, 25, 0, '#');
            VerticalLine right = new VerticalLine(1, 25, 74, '#');

            border.Add(up);
            border.Add(down);
            border.Add(left);
            border.Add(right);
        }
        internal bool IsHit( Figure figure )
        {
            foreach (var wall in border)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in border)
            {
                wall.Draw();
            }
        }

        
    }
}
