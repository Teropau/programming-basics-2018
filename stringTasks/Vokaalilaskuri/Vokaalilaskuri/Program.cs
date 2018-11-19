using System;

namespace Vokaalilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vokaalilaskuri");
            Console.WriteLine("Syötä teksti");
            string input = Console.ReadLine();
            string tmpInput = input.ToUpper();
            string vocals = "AEIOUYÄÖ";
            int vocalsCount = 0;
            for (int i = 0; i < tmpInput.Length; i++)
            {
                for (int j = 0; j < vocals.Length; j++)
                {
                    if (tmpInput[i] == vocals[j])
                    {
                        vocalsCount++;
                    }
                }
            }            
            Console.WriteLine($"Syötteessä {input} oli {vocalsCount} vokaalia.");

        }
    }
}
