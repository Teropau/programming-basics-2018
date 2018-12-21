﻿using System;

namespace Viitenumero
{
    class Program
    {   
        //Main program contains interface.
        static void Main(string[] args)
        {
            Intro();
            int setting;
            do
            {
                setting = int.Parse(Console.ReadLine());
                switch (setting)
                {
                    case 1:
                        RefNumCheck();
                        break;
                    case 2:
                        RefNumCreate();
                        break;
                    default:
                        Console.Write("Virheellinen syöte! Valitse 1 tai 2:");
                        break;
                }
            }while(setting != 1 || setting != 2);

        }
        static void Intro()
        {
            Console.WriteLine("1. Ohjelma terkistaa kotimaisen viitenumeron \n" +
                "2. Ohjelma luo koitimaisen viitenumeron.");
            Console.Write("Syötä ohjelman numero 1 tai 2, jonka haluat ajaa ja paina enter:");
        }
        /// <summary>
        /// Checks if input reference number is correct.
        /// </summary>
        static void RefNumCheck()
        {
            string refNum = InputFun();
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNum.Length];
            for (int i = 0; i < refNum.Length; i++)
            {
                refArr[i] = int.Parse(refNum[i].ToString());
            }
            for (int i = 0; i < refArr.Length-1; i++)
            {
                sum += refArr[refArr.Length - 2 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine($"Syöte:{refNum}");
            if (refArr[refArr.Length-1] == checkNum)
            {
                Console.WriteLine("Viitenumero on oikein.");
            }
            else
            {
                Console.WriteLine("Viitenumero on väärin.");
            }
        }
        /// <summary>
        /// Asks reference number as input.
        /// </summary>
        /// <returns>user input</returns>
        static string InputFun()
        {
            string input = "placeholder";
            int inputNum = 0;
            do
            {
                Console.Write("Syötä viitenumero, jossa on vain numeroita ja on 4-20 merkkiä pitkä:");
                input = Console.ReadLine();
            } while (input.Length <= 4 || input.Length >= 20 || !Int32.TryParse(input, out inputNum) || inputNum < 0);
            return input;
        }
        /// <summary>
        /// Creates a new reference number.
        /// </summary>
        static void RefNumCreate()
        {

            string refNumInput;
            do
            {
                Console.Write("Syötä viitenumeron alkuosa, joka on 3-19 merkkiä pitkä:");
                refNumInput = Console.ReadLine();
            } while (refNumInput.Length <= 3 || refNumInput.Length >= 19);
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNumInput.Length];
            for (int i = 0; i < refNumInput.Length; i++)
            {
                refArr[i] = int.Parse(refNumInput[i].ToString());
            }
            for (int i = 0; i < refArr.Length; i++)
            {
                sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine($"Syöte:{refNumInput}");
            string refNumOutput = refNumInput + checkNum;
            for (int i = 1; i < refNumOutput.Length; i++)
            {
                if(i%5 == 0)
                {
                    refNumOutput = refNumOutput.Insert(i, " ");
                }
            }
            Console.WriteLine($"Uusi viitenumero:{refNumOutput}");
        }       
    }
}
