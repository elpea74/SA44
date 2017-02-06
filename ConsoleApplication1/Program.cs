using System;

namespace Day2
{
    class Program1
    {
        public static void Main()
        {
            System.Console.WriteLine("1"); //1
            System.Console.Write("2");
            System.Console.Write("3");
            System.Console.WriteLine("4"); //234
            System.Console.WriteLine("5" + "6" + "7"); //567

            System.Console.WriteLine(5 + 6 + 7); //18

            int a = 5;
            System.Console.WriteLine(a); //5
            System.Console.WriteLine("a"); //a

            int b = 10;

            System.Console.WriteLine(a + b); //15
            System.Console.WriteLine("a" + "b"); //ab
            System.Console.WriteLine(a + "b");
            System.Console.WriteLine("a" + b);
            System.Console.WriteLine("She says \"Hello\""); //She says "Hello"

            Console.WriteLine("Three double quotes\"\"\""); //Three double quotes """

            Console.WriteLine("In C# to write \" in a string you must use \\\""); //In C# to write " in a string you must use\"

            Console.WriteLine("*\n**\n***");

            /* *
               **
               ***
               */

            System.Console.WriteLine("Name \t\t Age");
            System.Console.WriteLine("John Smith \t 21");
            System.Console.WriteLine("Jane Spencer \t 22");
            System.Console.WriteLine("Jimbo Shade \t 23");
            //Name          Age
            //John Smith    21
            //Jane Spencer  22
            //Jimbo Shade   23

            string doubleQuote = "\"";
            Console.WriteLine(doubleQuote + doubleQuote + doubleQuote);

            Console.WriteLine(a + " + " + b + " = " + a + b); // 5 + 10 = 510
            Console.WriteLine(a + " + " + b + " = " + (a + b)); //5 + 10 = 15
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b); //5 + 10 = 15
            Console.WriteLine("{2} = {1} + {0}", a, b, a + b); //15 = 10 + 5
        }
    }
}
