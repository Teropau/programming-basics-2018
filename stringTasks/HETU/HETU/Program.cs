using System;

namespace HETU
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            string input = Console.ReadLine();
            Tester(input);
        }
        static void Intro()
        {
            Console.WriteLine("Ohjelma tarkistaa, onko syötetty henkilötunnus mahdollinen.");
            Console.WriteLine("Syötä henkilötunnus mallissa ppkkvv:");
 
        }
        static void Tester(string hetu)
        {
            int day = int.Parse(hetu.Substring(0, 2));
            int month = int.Parse(hetu.Substring(2, 2));
            int year = int.Parse(hetu.Substring(4, 2));
            string dayMonthReminder = "Päivä tai kuukausi on väärin.";
            string dayReminder = "Päivä on väärin.";
            string correct = $"Henkilötunnus {hetu} on mahdollinen.";
            if (day > 31)
            {
                Console.WriteLine(dayReminder);
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                //31
                if (day < 31)
                {
                    Console.WriteLine(correct);
                }
                else
                {
                    Console.WriteLine(dayMonthReminder);
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                //30
                if (day < 30)
                {
                    Console.WriteLine(correct);
                }
                else
                {
                    Console.WriteLine(dayMonthReminder);
                }
            }
            else if (month == 2)
            {
                //28,29
                if(day < 29)
                {
                    Console.WriteLine(correct);
                }
                else
                {
                    Console.WriteLine(dayMonthReminder);
                }
            }
            else
            {
                Console.WriteLine("Kuukausi on väärin.");
            }
        }

    }
}
