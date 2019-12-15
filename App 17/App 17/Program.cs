using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            String a = Console.ReadLine();
            double b = Convert.ToDouble(a);
            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.Read();
        }
    }
}
