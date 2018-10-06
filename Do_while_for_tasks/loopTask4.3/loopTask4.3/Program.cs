using System;

namespace loopTask4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua, 5 per rivi.");

            Random rnd = new Random();
            int rndNumber;

            for(int i=1; i!=5; i++)
            {
                Console.Write($"Rivi{i} :");

                for(int y=0; y!=5; y++)
                {
                    rndNumber = rnd.Next(50);
                    Console.Write(rndNumber);
                    if(y!=4)
                    {
                        Console.Write(",");
                    }
                }

                Console.WriteLine();  
            }
        }
    }
}
