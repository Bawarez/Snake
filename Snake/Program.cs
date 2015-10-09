using System;
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
            HLine tline = new HLine(0, 78, 0, '+');
            HLine bline = new HLine(0, 78, 24, '+');
            VLine lline = new VLine(0, 24, 0, '+');
            VLine rline = new VLine(0, 24, 78, '+');
            tline.Draw();
            rline.Draw();
            bline.Draw();
            lline.Draw();


            Point tale = new Point(2, 12, '*');
            Snake snake = new Snake(tale,7,Direction.right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(78,25,'$');
            Point food = foodCreator.CreateFood();
            food.Show();


            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Show();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(150);


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(100);
                snake.Move();
            }
        }

    
    }
}
