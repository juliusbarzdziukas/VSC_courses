using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuZaidimas
{
    internal class Kortos
    {
        public List<Korta> KortuSarasas { get; set; }

        private Random rnd { get; set; }

        public Kortos()
        {
            KortuSarasas = new List<Korta>();
            rnd = new Random();
        }

        public void KortuKalade()
        {
            foreach (var z in (KortosZenklai[])Enum.GetValues(typeof(KortosZenklai)))
            {
                foreach (var t in (KortosTipai[])Enum.GetValues(typeof(KortosTipai)))
                {
                    KortuSarasas.Add(new Korta(z, t));
                }
            }
        }

        public int Taskai()
        {
            int verte = 0;
            foreach(var k in KortuSarasas)
            {
                verte += k.Verte();
            }
            return verte;
        }
        public virtual void Spausdinti()
        {
            foreach(var k in KortuSarasas)
            {
                k.Spausdinti();
            }
        }

        public void Remove(Korta k)
        {
            KortuSarasas.Remove(k);
        }

        public void Remove(int i)
        {
            KortuSarasas.Remove(KortuSarasas[i]);
        }

        public void Add(Korta k)
        {
            KortuSarasas.Add(k);
        }

        public int Count()
        {
            return KortuSarasas.Count();
        }

        public void Maisyti()
        {
            KortuSarasas = KortuSarasas.OrderBy( k => rnd.Next()).ToList();
        }

    }
}
