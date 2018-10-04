using System;

namespace LooopTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;
            int number;
            
            Console.WriteLine("Ohjelma laskee parittomien japarillisten lukjen summan.");
            Console.Write("Syötä luku");
            input = int.Parse(Console.ReadLine());

            while(i<= input)
            {
                if(i%2==0)
                {
                    evenSum = evenSum + i; //evenSum+=i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
                i++;
            }
            Console.WriteLine($"parillisten summa on {evenSum}");
            Console.WriteLine($"parittomien summa on {oddSum}");

        }
    }
}
