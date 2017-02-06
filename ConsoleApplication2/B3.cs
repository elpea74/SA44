using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopB
{
    class B3
    {
      public static void Main()
        {
            Console.Write("Enter salary: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(a * 1.13);
            Console.WriteLine("Total income is: {0:$#}", b);
            Console.ReadLine();
        }
    }
}
