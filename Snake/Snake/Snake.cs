using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            dots = new List<Point>();
            for (int i = 0; i < length; i++)
            {   
                Point p = new Point(tail);
                p.Move(i, direction);
                dots.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = dots.First();
            dots.Remove(tail);
            Point head = GetNewPoint();
            dots.Add(head);

            tail.Clear();
            head.Draw();

        }

        public Point GetNewPoint()
        {
            Point LastPoint = dots.Last();
            Point NextPoint = new Point(LastPoint);
            NextPoint.Move(1, direction);




            return NextPoint;
        }

        public void SnakeManagement(ConsoleKey key)
        {
            
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
        public bool Eat(Point food)
        {
            Point head = GetNewPoint();
            if (head.IsHit(food))
            {
                food.sign = head.sign;
                dots.Add(food);
                return true;
            }
            else 
                return false;
        }


        internal bool IsHitTail()
        {
            var head = dots.Last();
            for (int i = 0; i < dots.Count-2; i++)
            {
                if (head.IsHit(dots[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
