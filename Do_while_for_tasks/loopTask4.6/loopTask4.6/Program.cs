using System;

namespace loopTask4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää noppaa 1000 kertaa jakertoo, kuinka monta kutosta tuli.");

            int kutonen=0;

            for(int i = 1; i!=1002; i++)
            {
                Random rnd = new Random();

                Console.Write($"{i}. ");
                int noppa;
                do
                {
                    noppa = rnd.Next(7);
                } while (noppa == 0);

                Console.WriteLine(noppa);

                if(noppa==6)
                {
                    kutonen++;
                }  
            }

            Console.WriteLine($"heitoista {kutonen} oli kutosia.");
        }
    }
}
