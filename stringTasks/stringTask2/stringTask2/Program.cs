using System;

namespace stringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma korvaa 'e' kirjaimet '@' merkeillä.");
            Console.Write("Syötä merkkijono:");
            string s = Console.ReadLine();
            Console.WriteLine(": before :");
            Console.WriteLine(s);
            Console.WriteLine(": after :");
            Console.WriteLine(s.Replace("e", "@"));

        }
    }
}
