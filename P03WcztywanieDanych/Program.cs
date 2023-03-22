using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WcztywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak się nazywasz");
            string imie = Console.ReadLine();//.ToUpper(); //mozna od razu

            imie = imie.ToUpper();

            Console.WriteLine(imie);

            Console.WriteLine("Podaj wiek");
            string wiek= Console.ReadLine();
            int wiekInt = Convert.ToInt32(wiek);

            wiekInt = wiekInt + 1;

            Console.WriteLine("za rok bedziesz miał: " + wiekInt);
            //+ Convert.ToString(wiekInt)
            // konkatenacja ciąg tekstowych wykonuje automatyczną 
            // konwersję do napisu 

            Console.ReadKey();
        }
    }
}
