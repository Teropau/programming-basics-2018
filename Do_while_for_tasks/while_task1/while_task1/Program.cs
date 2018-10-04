using System;

namespace while_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates N! of given number.");
            Console.WriteLine("give a number.");

            while (true)
            {

                string input;
                int number;

                do
                {   

                    number = int.Parse(Console.ReadLine());

                } while (number <= 0);

                double i = 1;
                double F = 1;

                while (i != number)
                {
                    i = i + 1;
                    F = F * i;
                } 
                Console.Clear();
                Console.WriteLine("This program calculates N! of given number.");
                Console.WriteLine("give a number.");
                Console.WriteLine($"here you go: {F}");

            }
        }
    }
}
