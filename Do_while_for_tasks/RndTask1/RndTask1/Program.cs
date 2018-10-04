using System;

namespace RndTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret.");
            Console.WriteLine("  Luku         Nelöjuuri");

            Random rnd = new Random();

            int rndNumber;
            
            for(int i=0; i<10; i++)
            {
                rndNumber = rnd.Next(0,100);
                Console.WriteLine($"{i + 1}. {rndNumber}         {Math.Sqrt(rndNumber)}");
            }
           
        }
    }
}
