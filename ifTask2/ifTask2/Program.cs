using System;

namespace ifTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tarkistaa, onko luku positiivinen, negatiivinen vai nolla.");
            Console.Write("syötä numero");


            string input = Console.ReadLine();
            int number;

            while (!Int32.TryParse(input, out number))
            {

                Console.WriteLine("syöte ei ole numero");
                Console.Write("syötä numero");
                input = Console.ReadLine();

            }

            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");

            else if (number %2 == 0)
                Console.WriteLine($"Numero {number} on parillinen!");

            else
                Console.WriteLine($"Numero {number} on negatiivinen!");



        }
    }
}
