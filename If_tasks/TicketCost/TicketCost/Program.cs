using System;

namespace TicketCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.");
            Console.WriteLine("I will be your ticket price calculator today.");
            string opiskelija;
            double ale = 0;

            Console.WriteLine("Are you a student? Type your answer: YES or NO.");

            opiskelija = Console.ReadLine();
            if (opiskelija.ToLower() == "yes" || opiskelija == "y" || opiskelija == "ye" || opiskelija == "yep")
            {
                ale = 45;
            }

            Console.WriteLine("Are you a member of MTK? Type your ansver: YES or NO.");
            string MTK;
            MTK = Console.ReadLine();
            if (MTK.ToLower() == "yes" || MTK == "y" || MTK == "ye" || MTK == "yep")
            {
                ale += 15;
            }

            Console.WriteLine("Are you a serviceman? Type your answer: YES or NO.");
            string varus;
            varus = Console.ReadLine();
            if (varus.ToLower() == "yes" || varus == "y" || varus == "ye" || varus == "yep")
            {
                ale = 50;
            }

            Console.WriteLine("Give your age in years. Answer with numbers please.");
            string age;

            age = Console.ReadLine();
            int number;
            while (!Int32.TryParse(age, out number))
            {

                Console.WriteLine($"Your age can not be '{age}' ,stupedo.");
                Console.WriteLine("Type your age in numbers please.");
                age = Console.ReadLine();

            }
            double hinta = 16;
            if (number < 8)
            {
                ale = 100;
            }
            else if (number > 64)
            {
                ale = 50;
            }
            else if(number > 7 && number < 65)
            {
                hinta = 16;
            }

            hinta = (100 - ale) * hinta / 100;

            if(ale == 0)
            {
                hinta = 16;
            }

            Console.WriteLine($"Your ticket price is {hinta}e.");
            Console.WriteLine("Thank you and welcome!");
        }

    }
    
}
