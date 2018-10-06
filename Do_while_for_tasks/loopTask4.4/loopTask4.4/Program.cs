using System;

namespace loopTask4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää kolikkoa 20 kerrtaa ja");
            Console.WriteLine("kertoo, kuinka monta kruunaa ja klaavaa tuli.");
            int heads=0;
            int tails=0;

            Random rnd = new Random();
            double flip;

            for(int i=0; i!=20; i++)
            {
                flip = rnd.NextDouble();

                if(flip>0.5)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }

            }

            Console.WriteLine($"Kruunia: {heads}   Klaavaoja: {tails}");
        }
    }
}
