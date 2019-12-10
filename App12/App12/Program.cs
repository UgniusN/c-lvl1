using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(b);
                Console.Write(" * {0}", i);
                Console.Write(" = ");
                Console.WriteLine(i * b);
            }
            Console.ReadLine();
        }
    }
}
