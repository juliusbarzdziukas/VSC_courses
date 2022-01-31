using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuZaidimas
{
    internal class Zaidejas : Kortos
    {
        public string Vardas { get; }

        public Zaidejas(string vardas) : base()
        {
            Vardas = vardas;
        }

        public void TaskaiWrite()
        {
            Console.WriteLine($"{Vardas} taskai {Taskai()}");
        }

        public override void Spausdinti()
        {
            Console.WriteLine($"{Vardas} kortos {Count()} taskai {Taskai()}");
            base.Spausdinti();
        }

    }
}
