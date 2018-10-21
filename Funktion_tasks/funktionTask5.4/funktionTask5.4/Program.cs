using System;
using System.Collections.Generic;
namespace funktionTask5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greetings());
            Input();
        }
        public static string Greetings()
        {
            return $"Ohjelma kertoo, mikä kymmenestä annetusta luvusta on suurin.";
        }
        public static void Input()
        {
            List<int> list = new List<int>();
            for (int j = 1; j <= 11;)
            {
                Console.WriteLine($"Anna {j}. luku: ");
                string userInput = Console.ReadLine();
                int num;
                while (!Int32.TryParse(userInput, out num) || num < 0)
                {
                    Console.WriteLine("Virheellinen syöte.");
                    Console.Write("Syötä positiivinen luku: ");
                    userInput = Console.ReadLine();
                }
                j++;
                list.Add(num);
                if (j == 11)
                {
                    Console.WriteLine("Syötit luvut: ");
                    foreach (var element in list)
                        Console.Write($"{element},");
                    int biggest = list[0];
                    for (int i = 1; i < list.Count; i++)
                    {
                        biggest = Math.Max(biggest, list[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Suurin syöte oli {biggest}.");
                    break;
                }



                
            }
        }
    }
}
