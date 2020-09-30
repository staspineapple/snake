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
    }
}
