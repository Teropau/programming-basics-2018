using System;
using System.Collections.Generic;
using System.Linq;

namespace Self_evaluationTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää lukuja, kunnes syötät luvun -1,\njonka jälkeen kertoo syötettyjen lukujen summan.");
            int stop = 0;
            List<int> list = new List<int>();
            do
            {
                Console.Write("Syötä luku:  ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                int num;
                while (!Int32.TryParse(userInput, out num))
                {
                    Console.WriteLine("Virheellinen syöte.\nSyötä luku:");
                    userInput = Console.ReadLine();
                }
                if(num != -1)
                {
                    list.Add(num);
                }
                else
                {
                    stop++;
                }

            } while (stop == 0);
            double sum = list.Sum();
            Console.WriteLine($"Syötettyjen lukujen summa: {sum}");
        }
    }
}
