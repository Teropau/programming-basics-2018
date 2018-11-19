using System;

namespace stringTask_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma käsittelee pilkuilla erotetun datan.");
            string data = "aasi,kahvi,väsymys,kaneli,aivot,tietokone,pettymys,torstai,pora,koodi,tietokone,18.";
            Ver3(data);
        }
        #region Ver1
        /// <Summary>
        /// Funktion replaces dashes with line change.
        /// d=string data, wich is seperated with dashes.
        /// </summary>
        /// <param name="d"></param>
        static void Ver1(string d)
        {
            Console.WriteLine(d);
            Console.WriteLine(d.Replace(',', '\n'));
        }
        #endregion
        #region Ver2
        /// <summary>
        /// Funktion searches separator symbol and writes data inbetween d=string data
        /// </summary>
        /// <param name="d"></param>
        static void Ver2(string d)
        {
            int i = 0;
            while (true)
            {
                int p = d.IndexOf(',', i);
                if (p != -1)
                {
                    Console.WriteLine(d.Substring(i,p-i));
                    i = p + 1;
                }
                else
                {
                    Console.WriteLine(d.Substring(i));
                    break;
                }
            }
        }
        #endregion
        #region Ver3
        /// <summary>
        /// Funktio pilkkoo datan split metodia käyttäen.
        /// </summary>
        static void Ver3(string d)
        {
            string[] tempData = d.Split(',');
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(tempData[i].ToUpper());
            }

        }
        #endregion
    }
}
