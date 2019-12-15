using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio ploti");
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            Console.WriteLine("Iveskite staciakampio ilgi");
            String c = Console.ReadLine();
            int d = Convert.ToInt32(c);
            Console.WriteLine(b * d);
            Console.Read();
        }
    }
}
