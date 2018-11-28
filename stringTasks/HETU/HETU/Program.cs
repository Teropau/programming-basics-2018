using System;

namespace HETU2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            string input = Console.ReadLine(); ;
            int testOutcome = Tester(input);
            EndMarkGenerator(testOutcome, input);
        }
        static void Intro()
        {
            Console.WriteLine("Ohjelma tarkistaa, onko syötetty henkilötunnus mahdollinen ja taikoo tarkistusmerkin.");
            Console.WriteLine("Syötä henkilötunnus mallissa ppkkvv-xxx, ilman tarkistusmerkkiä:");

        }
        static int Tester(string hetu)
        {
            int day = int.Parse(hetu.Substring(0, 2));
            int month = int.Parse(hetu.Substring(2, 2));
            int year = int.Parse(hetu.Substring(4, 2));
            string century = "+-ABCDEFG";
            int centuryNum = 1800;
            int j = 0;
            for (int i = 0; i == century.Length; i++)
            {
                if (hetu.Contains(century[i]))
                {
                    year += centuryNum + j * i;
                    i = century.Length;
                }
                j += 100;
            }
            #region betaV.1
            //if (hetu.Contains('+'))
            //{
            //    year += 1800;

            //}
            //else if (hetu.Contains('-'))
            //{
            //    year += 1900;
            //}
            //else
            //{
            //    year += 2000;
            //}
            #endregion
            int correct = 1;
            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch (Exception)
            {
                Console.WriteLine("Päivämäärä on väärin.");
                correct = 0;
            }
            #region betaV.2
            //if (day > 31)
            //{
            //    Console.WriteLine(dayReminder);
            //}
            //else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //{
            //    //31
            //    if (day < 31)
            //    {
            //        correct = 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine(dayMonthReminder);
            //    }
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    //30
            //    if (day < 30)
            //    {
            //        correct = 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine(dayMonthReminder);
            //    }
            //}
            //else if (month == 2)
            //{
            //    //28,29
            //    if (day < 29)
            //    {
            //        correct = 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine(dayMonthReminder);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kuukausi on väärin.");
            //}
            #endregion
            return correct;
        }
        static void EndMarkGenerator(int validity, string hetu)
        {
            string endMarkList = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            if (validity == 1)
            {
                hetu = hetu.Remove(6, 1);
                int hetuNum = int.Parse(hetu);
                int endMarkNum = hetuNum % 31;
                Console.WriteLine($"Tarkistusmerkkisi on {endMarkList[endMarkNum]}");
            }
        }
    }
}
