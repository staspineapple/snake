using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sign;

        public Point()
        {
           x = 0;
           y = 0;
           sign = '$';
        }
        public Point(int x, int y, char sign)
        {
            this.x = x;
            this.y = y;
            this.sign = sign;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sign = p.sign;
        }
        public void PrintPoint ()
        {
            Console.WriteLine("X is equal = " + this.x);
            Console.WriteLine("Y is equal = " + this.y);
            Console.WriteLine("Sign is equal = " + this.sign);
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sign);
        }
        public void Move(int distance, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + distance;
            }
            if (direction == Direction.LEFT)
            {
                x = x - distance;
            }
            if (direction == Direction.DOWN)
            {
                y = y + distance;
            }
            if (direction == Direction.UP)
            {
                y = y - distance;
            }
        }
        public void Clear()
        {
            sign = ' ';
            Draw();
        }
    }
}
