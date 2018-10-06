using System;

namespace Looptask4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa lertotaulun luvuille 1-9.");
            int i = 1;
            int y = 1;
            int tulo;

            while(i!=10)
            {
                tulo = i * y;
                Console.WriteLine($"{i} x {y} = {tulo}");

                if (y == 9)
                {
                    y = 1;
                    i++;
                }
                else
                {
                    y++;
                }
            }
        }

    }
}
