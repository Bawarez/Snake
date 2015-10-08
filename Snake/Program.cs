﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine line = new HLine(2,8,4,'*');
            line.Draw();
            VLine line1 = new VLine(2, 8, 4, '*');
            line1.Draw();

            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p,6,Direction.right);
            snake.Draw();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Console.ReadLine();

        }

    
    }
}
