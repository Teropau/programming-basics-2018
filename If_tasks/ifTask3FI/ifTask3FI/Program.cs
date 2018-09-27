using System;

namespace ifTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma tarkistaa, onko luku positiivinen vai negatiivinen ja parillinen vai pariton vai onko se nolla.");
            Console.Write("syötä numero");

            string pos;
            string pari;
            string input = Console.ReadLine();
            int number;

            while (!Int32.TryParse(input, out number))
            {

                Console.WriteLine("syöte ei ole numero");
                Console.Write("syötä numero");
                input = Console.ReadLine();

            }
            if (number % 2 == 0)
                pari = " ja parillinen.";
            else
                pari = " ja pariton.";

            if (number == 0)
            {
                pos = "nolla";
                pari = ".";
            }
            else if (number > 0)
                pos = $"positiivinen";
            else
                pos = $"negatiivinen";



            Console.WriteLine($"Numero {number} on {pos}{pari}");

        }
    }
}
