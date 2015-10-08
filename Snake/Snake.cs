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

        public void Move()
        {
            Point t = points.First();
            points.Remove(t);
            Point h = points.Last();
            h.Move(1,d);
            points.Add(h);
            t.Clear();
            h.Show();
        }
    }
}
