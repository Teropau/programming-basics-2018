using System;

namespace Self_evaluationTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kirjoitetun rivin niin monta kertaa, kun rivissä on kirjaimia kertaa.");
            Console.Write("Kirjoita syöte: ");
            string input = Console.ReadLine();
            int numberOfLetters = 0;
            foreach(char letter in input)
            {
                numberOfLetters++;
            }
            for (int i = 1; i < numberOfLetters+1; i++)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(input);
            }
            Console.ReadLine();
        }
    }
}
