using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            HorizontalLine up = new HorizontalLine(0, 150, 0, '$');
            HorizontalLine down = new HorizontalLine(0, 150, 50, '$');
            VerticalLine left = new VerticalLine(1, 50, 0, '#');
            VerticalLine right = new VerticalLine(1, 50, 149, '#');

            up.Draw();
            down.Draw();
            left.Draw();
            right.Draw();
            Console.ReadKey();
        }
    }
}
