using System;

namespace Self_evaluationTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kirjoitetun rivin viisi kertaa.");
            Console.Write("Kirjoita syöte: ");
            string input = Console.ReadLine();
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(input);
            }
            Console.ReadLine();
        }
    }
}
