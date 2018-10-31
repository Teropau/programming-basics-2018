using System;

namespace ArrayExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma alustaaa kokonaislukutaulukon (10 alkiota), johon arvotaan lukuja 0...100.");
            int[] numbers = new int [10000];
            Random rnd = new Random();
                //set value to array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }
            //Get value from array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Ohjelman suiritus on päättynyt.");
        }
    }
}
