using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApP_25
{
    class Program
    {
        static void Main(string[] args)
        {
            String miestas = "Panevezys";
            String gatvesPav = "Naujamiescio";
            int namoNr = 53;
            int pastatymoMetai = 1989;
            Console.WriteLine(miestas);
            Console.WriteLine(gatvesPav);
            Console.WriteLine(namoNr);
            Console.WriteLine(pastatymoMetai);
            int pradziosMetai = 1982;
            Console.WriteLine(pradziosMetai);
            int stateMetu = pastatymoMetai - pradziosMetai;
            Console.WriteLine(stateMetu);
            Console.ReadLine();

        }
    }
}
