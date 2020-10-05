using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
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

        public void Move()
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
    }
}
