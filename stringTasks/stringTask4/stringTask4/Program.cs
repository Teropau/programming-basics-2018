using System;

namespace stringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa, onko syöte palindromi");
            Console.WriteLine("Syötä testattava sana:");
            string inPut = Console.ReadLine();
            string outPut=inPut;            
            for (int i = 0; i < inPut.Length; i++)
            {
                string re = inPut[i].ToString();
                outPut = outPut.Insert(inPut.Length-i-2, re);
            }
            if (inPut == outPut)
            {
                Console.WriteLine($"Syöte {inPut} on toisinpäin {outPut} ja on palindromi.");
            }
            else
            {
                Console.WriteLine($"Syöte {inPut} on ehkä toisinpäin {outPut} ja ei ole palindromi.");
            }
        }
    }
}
