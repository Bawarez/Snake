using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    class FoodCreator
    {
        int MapW;
        int MapH;
        char c;

        Random rnd = new Random();

        public FoodCreator(int w, int h, char c)
        {
            this.MapW = w;
            this.MapH = h;
            this.c = c;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2,MapW-2);
            int y = rnd.Next(2,MapH-2);
            return new Point(x, y, c);
        }

    }
}
