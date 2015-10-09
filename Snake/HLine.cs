using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HLine: Figure
    {
        
          
        public HLine(int xLeft, int xRight, int y, char c)
        {
            points = new List<Point>();
            for(int x=xLeft; x<=xRight; ++x)
            {
                Point p = new Point(x,y,c);
                points.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            foreach (Point p in points)
            {
                p.Show();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
