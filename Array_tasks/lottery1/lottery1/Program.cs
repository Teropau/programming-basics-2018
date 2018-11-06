using System;

namespace lottery1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lotto");
            Random rnd = new Random();
            int[] lottery = new int[7];
            for (int i = 0; i < lottery.Length;)
            {
                lottery[i] = rnd.Next(41);
                if (lottery[i] != 0)
                {
                    i++;
                }
            }
            bool didSwap;
            do
            {
                didSwap = false;
                for (int i = 0; i < lottery.Length - 1; i++)
                {
                    if (lottery[i] > lottery[i + 1])
                    {
                        int temp = lottery[i + 1];
                        lottery[i + 1] = lottery[i];
                        lottery[i] = temp;
                        didSwap = true;
                    }
                }
            } while (didSwap);
            for (int y = 0; y != lottery.Length; y++)
            {
                Console.Write(lottery[y]);
                if (y < lottery.Length-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"lisänumero: {rnd.Next(4)}");
            Console.WriteLine($"Tuplausnumero: {rnd.Next(40)}");
        }
    }
}
