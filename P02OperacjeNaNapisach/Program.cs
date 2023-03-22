﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
                          //012345678910
            int dlugosc = napis.Length; //11

            /* komentarz
             * wielo
             * wierszowy
            */

            Console.WriteLine(dlugosc);

            //F5 uruchomienie aktywnego programu 

            string s1 = napis.Substring(4); // ma kota
            string s2 = napis.Substring(4, 2); // ma

            Console.WriteLine(s1);


            bool czyZawiera= napis.Contains("ma"); // czy napis zawiera słowo "ma"
            // true

            bool b1 = true;
            bool b2 = false;

            string naDuze = napis.ToUpper();
            string naMale = napis.ToLower();

            // konkatenacja (łaczenie ciągów tekstowych)

            string s3 = "ala" + "ma" + "kota";
            // alamakota

            string s4 = napis + " i psa";

            string s5 = "ala".ToUpper(); //s5 = "ALA"

            string s6 = "ala";
            s6 = s6.ToUpper();

            s6.ToLower(); // wynik nie zostanie przypisany do zadnej zmiennej


            string s7= napis.Replace("ma", "bedzie miala");
            //ala bedzie miala kota

            int pozycja= napis.IndexOf("ma");
            // 4



            Console.ReadKey();

        }
    }
}
