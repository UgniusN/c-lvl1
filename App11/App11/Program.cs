using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu");
            String c = Console.ReadLine();
            Console.WriteLine("Iveskite antraji skaiciu");
            String d = Console.ReadLine();
            double a = Convert.ToDouble(c);
            double b = Convert.ToDouble(d);
            Console.WriteLine(a * b) ;
            Console.WriteLine(a / b);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.ReadLine();
        }
    }
}
