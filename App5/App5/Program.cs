﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            string spalva = "niekas";
            while (spalva != "meluoji")
            {
                Console.WriteLine("Kokia Jusu megstamiausias spalva?");
                spalva = Console.ReadLine();
                Console.WriteLine("Mano irgi!");
            }
        }
    }
}
