using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake: Figure
    {
        public Snake(Point t, int l, Direction d)
        {
            points = new List<Point>();
            for (int i= 0; i< l; ++i)
            {
                Point p = new Point(t);
                p.Move(i, d);
                points.Add(p);
            }
        }
    }
}
