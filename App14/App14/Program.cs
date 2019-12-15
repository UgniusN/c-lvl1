using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            String c = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu");
            String d = Console.ReadLine();
            double a = Convert.ToDouble(c);
            double b = Convert.ToDouble(d);
            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.Read();
        }
    }
}
