using System;

namespace stringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma laskee 'L' kirjainten määrän.");
            Console.Write("Syötä merkkijono:");
            string s = "lol";
            s = Console.ReadLine().ToUpper();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
