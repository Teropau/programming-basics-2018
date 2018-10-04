using System;

namespace LoopTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Ohjelma laskee N parilliset ja parittomat.");
            Console.WriteLine("Syötä luku.");

            do
            {

                luku = int.Parse(Console.ReadLine());

            } while (luku == 0);

            while (i != luku)
            {
                if (luku > 0)
                {
                    i++;
                }
                else
                {
                    i = i - 1;
                }

                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }

            }

            Console.WriteLine($"Parillisten summa: {evenSum}");
            Console.WriteLine($"parittomien summa: {oddSum}");


        }
    }
}
