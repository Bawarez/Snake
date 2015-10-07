using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;
            Show(x, y, '*');
            x = 4;
            y = 6;
            Show(x, y, '#');
            Console.ReadLine();

        }

        static void Show(int x, int y, char c)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(c);
        }
    }
}
