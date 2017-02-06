using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopB
{
    class B2
    {
        public static void Main()
        {
            Console.Write("Please enter a double precision number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(a);
            Console.WriteLine("The square root of this number is: {0:#.000}", b, + b);
            Console.ReadLine();
        }
        
    }
}
