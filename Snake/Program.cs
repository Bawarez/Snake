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

            Walls walls = new Walls(80,25);
            walls.Draw();

            Point tale = new Point(2, 12, '*');
            Snake snake = new Snake(tale,7,Direction.right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(78,25,'$');
            Point food = foodCreator.CreateFood();
            food.Show();

            Console.SetCursorPosition(0, 0);
            Console.Write("Score: 0");
            int s = 0;

            while (true)
            {
                if (walls.isHit(snake.points.Last()) || snake.IsHit())
                {
                    break;
                }
                   

                if (snake.Eat(food))
                {
                    s++;
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Score: "+s);
                    Thread.Sleep(10);
                    food = foodCreator.CreateFood();
                    food.Show();
                }
               

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(150);
                snake.Move();
            }
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("OLOLO!!!!!!!!!!!!!!!!!");
            Console.ReadLine();
        }
        
    }
}
