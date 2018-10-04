using System;

namespace while_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
            Console.WriteLine("Syötä numero.");

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
                    i++;
                    F += i;
                }
                Console.Clear();
                Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
                Console.WriteLine("Syötä numero.");
                Console.WriteLine($"here you go: {F}");

            }
        }
    }
}
