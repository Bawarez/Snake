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
            Point p1 = new Point(3,6,'*');
            Point p2 = new Point(6,3,'#');
            p1.Show();
            p2.Show();
            Console.ReadLine();

        }

    
    }
}
