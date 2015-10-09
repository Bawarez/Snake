using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public Point(int x, int y, char c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            c = p.c;
        }

        public void Move(int i, Direction d)
        {
            if (d == Direction.right)
                x += i;
            if (d == Direction.left)
                x -= i;
            if (d == Direction.up)
                y -= i;
            if (d == Direction.down)
                y += i;
        }

        public void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public void Clear()
        {
            c = ' ';
            Show();
        }

        public bool IsHit(Point p)
        {
            return ((this.x == p.x && this.y == p.y)||(this.x == p.x+1 && this.y == p.y));
        }
    }
}
