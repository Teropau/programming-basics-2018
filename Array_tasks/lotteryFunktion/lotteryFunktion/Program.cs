using System;

namespace lotteryFunktion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[40]; 
            Intro();
            RndLotteryNumbers(ref 7, 1);
            RndLotteryNumbers(ref 2, 3);
            PrintLottery();
        }
        static void Intro()
        {
            Console.WriteLine("Lotto");
            Console.WriteLine();
        }
        static void RndLotteryNumbers(ref int [] arr, int amount, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int rndNumber = rnd.Next(arr.Length);
                if(arr[rndNumber]==0)
                {
                    arr[rndNumber] = value;
                }
            }

        }

    }
}
