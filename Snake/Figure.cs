using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        public List<Point> points;

        public virtual void Draw()
        {
            foreach (Point p in points)
            {
                p.Show();
            }
        }

        internal bool IsHit(Point point)
        {
            foreach (var p in points)
            {
                if (point.IsHit(p))
                    return true;
            }
            return false;
        }
    }
}
