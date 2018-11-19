using System;

namespace stringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            Console.WriteLine(s);          
            Console.WriteLine($"Syötteessä on ({s.Length}) merkkiä.");
        }
    }
}
