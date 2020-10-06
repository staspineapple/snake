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
            Walls border = new Walls();
            border.Draw();

            Point start = new Point(4, 4, '@');
            Snake snake = new Snake(start, 4, Direction.RIGHT);
            snake.Draw();

            Fruit fruit = new Fruit(75, 25, '0');
            Point food = fruit.CreateFruit();
            food.Draw();
            
            while (true){

                if (border.IsHit(snake)||snake.IsHitTail() )
                {
                    break;
                }
                








                if (snake.Eat(food))
                {
                    food = fruit.CreateFruit();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeManagement(key.Key);
                }
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("████████ ██    ██     ███████  ██████  ██████      ██████  ██       █████  ██    ██ ██ ███    ██  ██████  ");
            Console.WriteLine("   ██     ██  ██      ██      ██    ██ ██   ██     ██   ██ ██      ██   ██  ██  ██  ██ ████   ██ ██       ");
            Console.WriteLine("   ██      ████       █████   ██    ██ ██████      ██████  ██      ███████   ████   ██ ██ ██  ██ ██   ███ ");
            Console.WriteLine("   ██       ██        ██      ██    ██ ██   ██     ██      ██      ██   ██    ██    ██ ██  ██ ██ ██    ██ ");
            Console.WriteLine("   ██       ██        ██      ██    ██ ██   ██     ██      ██      ██   ██    ██    ██ ██  ██ ██ ██    ██ ");
            Console.WriteLine("   ██       ██        ██       ██████  ██   ██     ██      ███████ ██   ██    ██    ██ ██   ████  ██████  ");
            Console.WriteLine("                                                                                                          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any buttom to exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            
        }
    }
}
