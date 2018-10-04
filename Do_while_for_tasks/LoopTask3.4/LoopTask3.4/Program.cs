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

                } while (number == 0);

                double i = 0;
                double F = 0;

                while (i != number)
                {
                    if(number>0)
                    {
                        i++;
                    }
                    else
                    {
                        i = i - 1;
                    }

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
