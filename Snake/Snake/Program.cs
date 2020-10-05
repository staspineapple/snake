using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            HorizontalLine up = new HorizontalLine(0, 75, 0, '$');
            HorizontalLine down = new HorizontalLine(0, 75, 25, '$');
            VerticalLine left = new VerticalLine(1, 25, 0, '#');
            VerticalLine right = new VerticalLine(1, 25, 74, '#');

            up.Draw();
            down.Draw();
            left.Draw();
            right.Draw();

            Point start = new Point(4, 4, '@');
            Snake snake = new Snake(start, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
          
            while (true)
        
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeManagement(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


            Console.ReadKey();
        }
    }
}
