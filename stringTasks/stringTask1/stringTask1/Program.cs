using System;

namespace stringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee merkit");
            Console.Write("Syötä merkkijono:");
            string s = Console.ReadLine();
            Console.WriteLine(s);          
            Console.WriteLine($"Syötteessä on ({s.Length}) merkkiä.");
        }
    }
}
