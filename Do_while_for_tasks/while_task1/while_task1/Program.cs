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
                input = Console.ReadLine();
                int number;
                while (!Int32.TryParse(input, out number))
                {
                    Console.Clear();
                    Console.WriteLine("Don't u know what anumber is??");
                    Console.WriteLine("give a NUMBER!      please..");
                    input = Console.ReadLine();
                }

                if (number < 0)
                {
                    Console.WriteLine("Input is invalid. Are you trying to break me? Fat chance. just restart the program.");
                }

                if(number == 0)
                {
                    Console.WriteLine("No zeroes please");
                }

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
