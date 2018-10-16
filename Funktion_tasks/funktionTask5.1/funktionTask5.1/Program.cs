using System;

namespace funktionTask5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars();
            Console.WriteLine();
        }
        public static void PrintStars()
        {
            Console.Write("Kirjota luku:");
            string input = Console.ReadLine();
            int luku;
            int.TryParse(input, out luku);
            if (luku < 0)
            {
                Console.WriteLine("Syöte on virheellinen.");
            }
            else
            {
                for (int i = 0; i <luku; i++)
                {
                    Console.Write("*");
                }
            }


        }
        
    }
}
