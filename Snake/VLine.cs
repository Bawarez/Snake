using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VLine: Figure
    {
       public VLine(int yTop, int yBot, int x, char c)
        {
            points = new List<Point>();
            for (int y = yTop; y <= yBot; ++y)
            {
                Point p = new Point(x,y,c);
                points.Add(p);
            }
        }
    }
}
