using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaciu:");
            String a = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaciu:");
            String b = Console.ReadLine();
            Console.WriteLine(a.Equals(b));
            Console.Read();
        }
    }
}
