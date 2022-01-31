using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuZaidimas
{

    internal class Korta
    {
        public KortosZenklai Zenklas { get; }
        public KortosTipai Tipas { get; }
        public Korta(KortosZenklai zenklas, KortosTipai tipas){
            Zenklas = zenklas;
            Tipas = tipas; 
        }

        public void Spausdinti()
        {
            Console.WriteLine($"{Tipas} {Zenklas} {Verte()}");
        }

        public int Verte()
        {
            switch ((int)Tipas)
            {
                case var n when (n <= 10):
                    return (int)Zenklas * n;
                default:
                    return (int)Zenklas * 10;
            }
        }
    }
}
