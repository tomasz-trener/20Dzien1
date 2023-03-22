using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13InnePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while 

            string zdanie = "ala ma kota";
            int i = 0;

            // wypisz po kolejne znaki w zdaniu 
            do
            {
                Console.WriteLine(zdanie.Substring(i,1));
                i++;
            } while (i<zdanie.Length);

            Console.ReadKey();


            // mógłbym to samo zadanie zrobić przy pomocy pętli for 

            for (int k = 0; k < zdanie.Length; k++)
                Console.WriteLine(zdanie.Substring(k,1));

            // najcześciej stosujemy:
             // for
             // while
             // do while 

            // foreeach - omówimy gdy poznamy kolekcje obiektów 
            
        }
    }
}
