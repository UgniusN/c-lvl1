using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            String a = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu");
            String b = Console.ReadLine();
            Console.WriteLine("Iveskite trecia skaiciu");
            String c = Console.ReadLine();
            double d = Convert.ToDouble(a);
            double e = Convert.ToDouble(b);
            double f = Convert.ToDouble(c);
            double vid = (d + e + f) / 3;
            Console.WriteLine(vid);
            Console.Read();
        }
    }
}
