﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; // operator przypisania 
            bool czy = a == 1; // == operator porównania 

            a = a + 1;
            a++; // zwieksz o 1

            a += 5;// zwieksz o 5 lub dowolna inną 

            a *= 2; // przemnoz przez 2 czyli to samo co a=a*2

            a -= 5; // zmniejsz o 5

            a /= 2; // przedziel przez 2 

            bool czyMniejsze = a < 5; // mniejsze od 
            bool czyWiekszeLubRowne = a >= 5;

            bool b1 = a < 5 || a > 10; // lub 
            bool b2 = a > 5 && a < 10; // i 

            bool b3 = a != 5; // różne od...

            bool b4 = !(a == 5); // ! - zaprzeczenie 
        }
    }
}
