using System;

namespace arrayTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RND GRID");
            int widht = 10;
            int hight = 20;
            int[,] grid = new int [widht,hight];
            Random rnd = new Random();
            for (int i = 0; i < widht; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                   grid[i, j] = rnd.Next(100);

                }

            }
            for (int i = 0; i < widht ; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    Console.WriteLine($"[{i:d2},{j:d2}] = {grid[i,j]:d2} ");
                }
                
            }
        }
    }
}
