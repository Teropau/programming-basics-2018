using System;
using System.Linq;
namespace arrayTask6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random keskiarvo");
            int[] iT = new int[100];
            Random rnd = new Random();
            // Lukujen arvonta - alustetaan taulukko
            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(50);
            }
            // Laske summa ja keskiarvo
            int summa = iT.Sum();
            int average = summa / 100;
            //tulosta vastaus
            for (int i = 0; i < iT.Length; i++)
            {
                Console.Write($"{i+1}. ");
                Console.WriteLine(iT[i]);
            }
            Console.WriteLine($"keskiarvo: {average}");
        }
    }
}
