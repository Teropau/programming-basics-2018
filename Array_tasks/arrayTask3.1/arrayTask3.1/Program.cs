using System;

namespace arrayTask3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvotaan 10 lukua ja esitetään ne.");
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(20);
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"[{j}] = {arr[j]:D2}");
            }
        }
    }
}
