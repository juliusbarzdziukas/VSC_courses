using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuZaidimas
{
    internal class Zaidimas
    {
        public List<Zaidejas> Zaidejai { get; set; }
        public Kortos Kalade { get; set; }

        public Zaidimas()
        {
            Kalade = new Kortos();
            Kalade.KortuKalade();
            Zaidejai = new List<Zaidejas>();
        }

        public void NaujasZaidejas(string vardas)
        {
            Zaidejai.Add(new Zaidejas(vardas));
        }

        public void Dalinti(Kortos kortos)
        {
            kortos.Maisyti();
            int kiekis = kortos.Count() / Zaidejai.Count();
            int liko = kortos.Count() % Zaidejai.Count();
            for (var i = 0; i < Zaidejai.Count; i++)
            {
                for (var j = 0; j < kiekis; j++)
                {
                    Zaidejai[i].Add(kortos.KortuSarasas[0]);
                    kortos.Remove(0);
                }
            }
            for (var i = 0; i < liko; i++)
            {
                Zaidejai[i].Add(kortos.KortuSarasas[0]);
                kortos.Remove(0);
            }
        }

        public void Dalinti()
        {
            Dalinti(Kalade);
        }

        public void Zaisti()
        {
            Dalinti();
            Taskai();
            Spausdinti();
        }
        public void Taskai()
        {
            foreach(var z in Zaidejai)
            {
                z.TaskaiWrite();
            }
        }
        public void Spausdinti()
        {
            foreach (var z in Zaidejai)
            {
                z.Spausdinti();
            }
        }
    }
}