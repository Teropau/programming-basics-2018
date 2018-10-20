using System;

namespace funktionTask5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Intro();
            Console.WriteLine(Compare(input, 5, 10)); 
        }
        public static int Intro()
        {
            Console.WriteLine("Ohjelma kertoo, onko luku liian pieni, liian suuri vai sopiva.");
            Console.Write("Anna luku: ");
            string userInput = Console.ReadLine();
            int num;
            while (!Int32.TryParse(userInput,out num))
            {
                Console.WriteLine("Virheellinen syöte.");
                Console.Write("Syötä luku: ");
                userInput = Console.ReadLine();
            }
            return num;
        }
        public static string Compare(int input, int lower, int upper)
        {
            if (input < lower)
            {
                return $"{input} on pienempi kuin alaraja {lower}.";
            }
            else if (input > upper)
            {
                return $"{input} on suurempi kuin yläraja {upper}.";
            }
            else
            {
                return $"Luku {input} sijoittuu alarajan {lower} ja ylärajan {upper} väliin.";
            }
        }

    }
}
