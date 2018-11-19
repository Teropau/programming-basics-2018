using System;

namespace stringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="Hello World!";
            Console.WriteLine(": before :");
            Console.WriteLine(s);
            Console.WriteLine(": after :");
            Console.WriteLine(s.Replace("e", "@"));

        }
    }
}
