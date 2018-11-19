using System;

namespace stringTask4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo, onko syöte palendromi.");
            Console.WriteLine("Syötä sana:");
            string inPut = Console.ReadLine();
            string inPutX = inPut.ToUpper();
            int validityCount = 0;
            inPutX = inPutX.Replace(" ", "");
            for (int i = 0; i < inPutX.Length; i++)
            {
                if(inPutX[i] == inPutX[inPutX.Length - 1 - i])
                {
                    validityCount++;
                }
            }
            if (validityCount == inPutX.Length)
            {
                Console.WriteLine($"Syöte {inPut} on paledromi.");
            }
            else
            {
                Console.WriteLine($"Syöte {inPut} ei ole paledromi.");
            }            
        }
    }
}
