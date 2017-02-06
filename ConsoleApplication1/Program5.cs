﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program5
    {
        public static void Main()
        {
            int a = 1;
            Console.WriteLine(a); //1

            a++;  //a++ means a = a+1 => 2

            Console.WriteLine(a); //2

            a--; //a-- means a = a-1 => 1

            Console.WriteLine(a); //1

            ++a; // ++a means a = a+1 =>2
            Console.WriteLine(a); //2

            int b = a; //at this point, b = 2

            Console.WriteLine(a++); //2
            Console.WriteLine(b); b = b + 1;  //2

            Console.WriteLine(++a); //4

            b = b + 1; Console.WriteLine(b); //4

            a += 5; // a = a+5
            a -= 5;
            a *= 5;
            a /= 5;
            a += 1; //not 1 += a, 1 isn't variable
        }
    }
}
