using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuZaidimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Pradeti();
            Console.ReadKey();
        }
        public void Pradeti()
        {
            Zaidimas z = new Zaidimas();
            char c;
            do
            {
                z.NaujasZaidejas(Nuskaityti.String("Zaidejas"));
                c = Nuskaityti.Char("Kitas zaidejas? t (taip)");
            } while (c == 't' || c == 'T');
            z.Zaisti();
        }
    }
}
