using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            bool c1 = wzrost > 180;

            if (c1) //wzrost> 180
            {
                Console.WriteLine("wysoki");
            }
            else
            {
                Console.WriteLine("niski");
            }

            // jak ma wzrost < 160 to niski, jak od 160 do 180 to średni a ponad 180 to wysoki 

            // zagnieżdzone ify 

            if(wzrost<160)
                Console.WriteLine("niski");
            else
                if (wzrost > 180)
                    Console.WriteLine("wysoki");
                else
                    Console.WriteLine("średni");

            // zamiast tego można (lepiej) stosować else ify 
      
            if(wzrost<160)
                Console.WriteLine("niski");
            else if(wzrost>180)
                Console.WriteLine("wysoki");
            else
                Console.WriteLine("niski");

            // kiedy było by więcej opcji np: bardzo niski, niski, średni, wysoki i bardzo wysoki
            
            if (wzrost < 150)
                Console.WriteLine($"twój wzrost to {wzrost} i jest bardzo niski");
            else if (wzrost < 160)
                Console.WriteLine($"twój wzrost to {wzrost} i jest niski");
            else if (wzrost < 170)
                Console.WriteLine($"twój wzrost to {wzrost} i jest sredni");
            else if (wzrost < 180)
                Console.WriteLine($"twój wzrost to {wzrost} i jest wysoki");
            else
                Console.WriteLine($"twój wzrost to {wzrost} i jest bardzo wysoki");

            // żeby zapobiec powtarzającym się kawałkom kodu

            string raport;
            if (wzrost < 150)
                raport = "bardzo niski";
            else if (wzrost < 160)
                raport = "niski";
            else if (wzrost < 170)
                raport = "średni";
            else if (wzrost < 180)
                raport = "wysoki";
            else
                raport = "bardzo wysoki";

            raport = $"twój wzrost to {wzrost} i jest {raport}";

            Console.WriteLine(raport);

            // -- operator 3 argumentowy 

            string wyn;
            if (wzrost > 180)
                wyn = "wysoki";
            else
                wyn = "niski";

            string wyn1 = wzrost > 180 ? "wysoki" : "niski";

            string wyn2 = wzrost > 180 ? "bardzo wysoki" : wzrost < 160 ? "niski" : "średni";




            Console.ReadKey();

        }
    }
}
