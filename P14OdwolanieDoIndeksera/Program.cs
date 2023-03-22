using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14OdwolanieDoIndeksera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";

            string znakPiaty = s.Substring(4, 1);
            char znak = s[4]; // jeden znak mozemy przechowywac w zmiennej typu char 

            char innyZnak = 'g'; // znaki podajemy w apostrofach 

            string s2 = "ala" + 'g';

            if ("a" ==Convert.ToString('a'))
            {

            }

            foreach (char c in s) 
            {
                Console.WriteLine(c);
            }
         
        }
    }
}
