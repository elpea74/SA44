using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopB1
{
    class B1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a double precision number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine("The square root of this number is: " + b);
            Console.ReadLine();
        }
    }
}
