using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            String vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde");
            String pavarde = Console.ReadLine();
            Console.WriteLine("{0}{1}",vardas,pavarde);
            Console.Read();
        }
    }
}
