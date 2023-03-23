using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieInstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj równanie matematyczne");
            string rownanie = Console.ReadLine();
            // 4+5
            // 012


            string op= rownanie.Substring(1, 1);
            int liczba1 = Convert.ToInt32(rownanie.Substring(0, 1));
            int liczba2 = Convert.ToInt32(rownanie.Substring(2));

            double? wynik=null;
            // string s = null;

            if (!(liczba2 == 0 && op=="/"))
            {
                if (op == "+")
                    wynik = liczba1 + liczba2;
                else if (op == "-")
                    wynik = liczba1 - liczba2;
                else if (op == "*")
                    wynik = liczba1 * liczba2;
                else if (op == "/")
                    wynik = Convert.ToDouble(liczba1) / liczba2;
                else
                    Console.WriteLine("nieznany operator");
            }
            else
                Console.WriteLine("próba dzielenia przez 0");

            if (wynik != null)
                Console.WriteLine(wynik);
          

            Console.ReadKey();
        }
    }
}
