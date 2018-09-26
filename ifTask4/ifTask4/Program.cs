using System;

namespace ifTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee 3 lukua nousevaan järjestykseen.");
            Console.Write("syötä 1. luku.");
            string userinput = Console.ReadLine();
            int x = int.Parse(userinput);

            Console.Write("syötä 2. luku.");
            userinput = Console.ReadLine();
            int y = int.Parse(userinput);

            Console.Write("syötä 3. luku.");
            userinput = Console.ReadLine();
            int z = int.Parse(userinput);

            Console.WriteLine($"Syötit luvut {x}-{y}-{z}.");
            Console.Write("Luvut suuruusjärjestyksessä:");
            if (x<y && y<z)
            { 
                Console.WriteLine($"{x}-{y}-{z}");
            } 
            else if(x<y && y>z && x<z)
            {
                Console.WriteLine($"{x}-{z}-{y}");
            }
            else if (x<y && y>z && x>z)
            {
                Console.WriteLine($"{z}-{x}-{y}");
            }
            else if(x>y && y>z)
            {
                Console.WriteLine($"{z}-{y}-{x}");
            }
            else if(x>y && y<z && x>z)
            {
                Console.WriteLine($"{y}-{z}-{x}");
            }
            else if(x>y && y<z && x<z)
            {
                Console.WriteLine($"{y}-{x}-{z}");
            }



        }
    }
}
