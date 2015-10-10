using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake: Figure
    {
        Direction d;
        public Snake(Point t, int l, Direction _d)
        {
            d = _d;
            points = new List<Point>();
            for (int i= 0; i< l; ++i)
            {
                Point p = new Point(t);
                p.Move(i, d);
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point t = points.First();
            points.Remove(t);

            Point h = NextPoint();
            points.Add(h);

            t.Clear();
            h.Show();
        }

        public Point NextPoint()
        {
            Point p = new Point(points.Last());
            p.Move(1, d);
            return p;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
                d = Direction.right;
            else if (key == ConsoleKey.LeftArrow)
                d = Direction.left;
            else if (key == ConsoleKey.UpArrow)
                d = Direction.up;
            else if (key == ConsoleKey.DownArrow)
                d = Direction.down;
        }

        internal bool Eat(Point food)
        {
            Point h = NextPoint();
            if (h.IsHit(food))
            {
                food.c = h.c;
                points.Add(food);
                return true;
            }
            else
                return false;
        }

        internal bool IsHit()
        {
            Point h = new Point(points.Last());
            for (int i=0; i<points.Count-2; ++i)
            {
                if (h.IsHit(points[i]))
                    return true;
            }
            return false;
        }
    }
}
