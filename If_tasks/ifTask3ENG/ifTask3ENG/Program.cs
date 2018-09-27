using System;

namespace ifTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program tells if given number is even or odd, positive or negative and if it is a zero.");
            Console.Write("Give a number.");

            string pos;
            string pari;
            string input = Console.ReadLine();
            int number;

            while (!Int32.TryParse(input, out number))
            {

                Console.WriteLine("Input is not a number!");
                Console.Write("Give a number.");
                input = Console.ReadLine();

            }
            if (number % 2 == 0)
                pari = " and even.";
            else
                pari = " and odd.";

            if (number == 0)
            {
                pos = "zero";
                pari = ".";
            }
            else if (number > 0)
                pos = $"positive";
            else
                pos = $"negative";



            Console.WriteLine($"Number {number} is {pos}{pari}");

        }
    }
}
