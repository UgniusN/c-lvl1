using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksta:");
            String a = Console.ReadLine();
            Console.WriteLine(String.IsNullOrEmpty(a));
            Console.ReadLine();
        }
    }
}
