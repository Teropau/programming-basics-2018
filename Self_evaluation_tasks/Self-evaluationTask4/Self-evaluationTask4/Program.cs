using System;
using System.Collections.Generic;
namespace Self_evaluationTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma suorittaa kahden syötetyn luvun\nyhteenlaskun, vähennyslaskun, kertolaskun ja jakolaskun.");
            List<decimal> list = new List<decimal>();
            for (int i = 1; i < 3; i++)
            {
                Console.Write("Syötä Luku: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                decimal num;
                while (!decimal.TryParse(userInput, out num))
                {
                    Console.Write("Virheellinen syöte\nSyötä luku: ");
                    userInput = Console.ReadLine();
                }
                list.Add(num);
            }
            decimal firstInput = decimal.Round(list[0], 2, MidpointRounding.AwayFromZero);
            decimal secondInput = decimal.Round(list[1], 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{firstInput} + {secondInput} = {decimal.Round(firstInput + secondInput, 2, MidpointRounding.AwayFromZero)}");
            Console.WriteLine($"{firstInput} - {secondInput} = {decimal.Round(firstInput - secondInput, 2, MidpointRounding.AwayFromZero)}");
            Console.WriteLine($"{firstInput} * {secondInput} = {decimal.Round(firstInput * secondInput, 2, MidpointRounding.AwayFromZero)}");
            Console.WriteLine($"{firstInput} / {secondInput} = {decimal.Round(firstInput / secondInput, 2, MidpointRounding.AwayFromZero)}");
        }
    }
}
