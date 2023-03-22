using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- część 1 -----");
            Console.WriteLine("Podaj koljeno liczby");

            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int suma = liczba1 + liczba2;

            int liczbaZnakow = Convert.ToString(suma).Length;

            Console.WriteLine(suma);
            Console.WriteLine(liczbaZnakow);

            string raport1 = "wynik " + suma + " złożony jest z: " + liczbaZnakow + " znaków";
            string raport2 = $"wynik {suma} złozony jest z: {liczbaZnakow} znaków";
            string raport3 = string.Format("wynik {0} złożony jest {1} znaków",
                suma, liczbaZnakow);

            Console.WriteLine(raport3);


            Console.WriteLine("------ częśc 2 --------");
            Console.WriteLine("podaj dwie liczby oddzielone spacja");
            string liczby = Console.ReadLine(); //200 10
                                                //012345

            int pozSpacji = liczby.IndexOf(" "); //pozycja spacji = 3

            int nowaLiczba1 = Convert.ToInt32(liczby.Substring(0, pozSpacji));
            int nowaLiczba2 = Convert.ToInt32(liczby.Substring(pozSpacji+1));

            int nowaSuma = nowaLiczba1 + nowaLiczba2;
            Console.WriteLine(nowaSuma);

            Console.ReadKey();
        }
    }
}
