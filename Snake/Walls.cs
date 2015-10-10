using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> walls;

        public Walls(int MapW, int MapH)
        {
            walls = new List<Figure>();

            HLine tline = new HLine(0, MapW-2, 0, '+');
            HLine bline = new HLine(0, MapW-2, MapH-1, '+');
            VLine lline = new VLine(0, MapH-1, 0, '+');
            VLine rline = new VLine(0, MapH-1, MapW-2, '+');

            walls.Add(tline);
            walls.Add(rline);
            walls.Add(bline);
            walls.Add(lline);
        }

        internal bool isHit(Point h)
        {
            foreach (var wall in walls)
            {
                if (wall.IsHit(h))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in walls)
            {
                wall.Draw();
            }
        }
    }
}
