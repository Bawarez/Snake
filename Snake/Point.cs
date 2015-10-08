﻿using System;
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

        public void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
