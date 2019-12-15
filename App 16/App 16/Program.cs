using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_16
{
    class Program
    {
        static void Main(string[] args)
        {
            String mokPavadinimas = "CodeAcademy";
            String kursPavadinimas = "dotNet Kursai";
            int studSkaicius = 20;
            DateTime data = DateTime.Today;
            DateTime startDate = new DateTime(2019, 12, 11);
            DateTime endDate = new DateTime(2020, 02, 25);
            TimeSpan value = endDate.Subtract(startDate);
            int diff = value.Days;
            int sav = diff / 7;
            int darb = diff - sav * 2 - sav;
            Console.WriteLine(value);
            Console.WriteLine(kursPavadinimas); 
            Console.WriteLine(studSkaicius);
            Console.WriteLine(diff);
            Console.WriteLine(sav);
            Console.WriteLine(darb);
            Console.Read();

        }
    }
}
