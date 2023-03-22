using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12BreakIContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj zdanie");
            string zdanie = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("wczytaj wyraz lub napisz 'koniec'");
                string wyraz = Console.ReadLine();


                if (string.IsNullOrEmpty(wyraz) || wyraz=="i" || wyraz =="a")
                { 
                    // zapiezpiczenie przed wyszukiwaniem po ciągu pustym
                    // gdy tego nie zrobimy to algorytm wyszukiwania nie będzie działać poprawnie 
                    Console.WriteLine("nie możesz szukać tego znaku");
                    continue; // przerywa daną iterację pętli i wraca na początek następnej iteracji 
                }

                if (wyraz=="koniec")
                    break; // wyjdź z pętli w której jesteś 
                
                //ala ma kota i ma psa
                //                   ma
                int i = 0;
                int licznik = 0;
                while (i <= zdanie.Length - wyraz.Length)
                {
                    string podciag = zdanie.Substring(i, wyraz.Length);
                    if (podciag == wyraz)
                        licznik++;
                    i++;
                }

                string wzor = "Słowo/znak '{0}' występuje w podanym zdaniu {1} razy.";

                Console.WriteLine(string.Format(wzor, wyraz, licznik));
            }


            Console.WriteLine("koniec programu");
            Console.ReadKey();

        }
    }
}
