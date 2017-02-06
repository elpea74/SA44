using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program4
    {
        public static void Main()
        {
            Console.WriteLine("Entrance Ticket: $25.");
            Console.Write("Please enter the number of tix that you want: ");

           string input = Console.ReadLine(); //assume input is valid number
            int numTix = Convert.ToInt32(input);

          //bool is OK = Int32.TryParse(input, out, numTix); //alternative          

          // int numTix = Convert.ToInt32(Console.ReadLine()); //shortcut

            Console.WriteLine("Total cost = {0}", numTix * 25);
        }
    }
}
