using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;

            while (k<10)
            {
                k++;
                Console.WriteLine(k);
            }

            Console.ReadKey();

            // zastanówmy się nad problemem z zdania p04
            // tym razem chcemy aby program mógł przyjmować dowolną liczbę cyfr 

            //  10 200
            //  012345
            string rownania = "10 200";
            int pozycjaSpacji = -1;
            int i = 0;
            while (i<rownania.Length)
            {
                if (rownania.Substring(i, 1) == " ")
                    pozycjaSpacji = i;
                
                i++;
            }
           
            // zrobiliśmy własną funkcję, która działa jak
            // wbudowana funkcja index of 
        }
    }
}
