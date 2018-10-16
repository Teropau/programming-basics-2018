using System;

namespace funktionTask5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo, kumpi kahdesta satunnaisesta luvusta on pienempi.");
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            int num1 = rnd1.Next(100);
            int num2 = rnd2.Next(100);
            Compare(num1, num2);
        }
        public static void Compare(int num1, int num2)
        {
            if(num1<num2)
            {
                Console.WriteLine($"Luku{num1} on pienempi kuin luku {num2}.");
            }
            else
            {
                Console.WriteLine($"Luku{num2} on pienempi kuin luku {num1}.");
            }
        }
    }
}
