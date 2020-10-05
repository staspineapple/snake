using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Fruit
    {
        int x;
        int y;
        char sign;

        Random rand = new Random();
        public Fruit(int x, int y, char sign)
        {
            this.x = x;
            this.y = y;
            this.sign = sign;

        }

        public Point CreateFruit()
        {
            
            int xx = rand.Next(2, x - 2);
            int yy = rand.Next(2, y - 2);
            return new Point(xx,yy,sign);
        }
    }
}
