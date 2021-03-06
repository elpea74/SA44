﻿using System;

namespace Day2
{ 
    class Program2
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a + b);

            double c = 70.8;
            double d = 170.1;
            
            Console.WriteLine(c + d); //240.9

            Console.WriteLine(a + c); //75.8

            Console.WriteLine("He weighs {0} kg and is {1} cm tall", c, d);
            //He weighs 70.8 kg and is 170.1 cm tall

            Console.WriteLine("He weighs {0:0.000} kg and is {1:0.000} cm tall", c, d);
            //He weighs 70.800 kg and is 170.100 cm tall

            double balance = 12345.67892345;
            double bigbalance = 12345678902345;
            Console.WriteLine("${0}", balance); //12345.678912345
            Console.WriteLine("${0:0.00}", balance); //12345.68
            Console.WriteLine("${0:0,000.00}", balance); //1,2345.68

            Console.WriteLine("${0:0,000.00}", bigbalance); //123,456,789,0123,345.00
            Console.WriteLine("${0:0,0.00}", bigbalance); //123,456,789,0123,345.00

            double x = 123;
            double y = 33.334;

            Console.WriteLine("{0}     {1}", x, y); //123       33.334
            Console.WriteLine("{0:0.0}     {1:0.0}", x, y); //123.0       33.3
            Console.WriteLine("{0:#.#}     {1:#.#}", x, y); //123       33.3

            Console.WriteLine("{0:00000}", x); //00123
            Console.WriteLine("{0:00}", x); //123
            Console.WriteLine("{0:###00}", x); //123

        }
    }
}
