using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            String a = Console.ReadLine();
            int c = Convert.ToInt32(a);
            Console.WriteLine("Iveskite antra skaiciu");
            String b = Console.ReadLine();
            int d = Convert.ToInt32(b);
            c++;
            d--;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.Read();
        }
    }
}
