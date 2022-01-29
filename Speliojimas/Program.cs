using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speliojimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Zaidimas();
            Console.ReadKey();
        }
        public void Zaidimas()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 10);
            int n1;
            do
            {
                n1 = NuskaitytiInt("Atspekite skaiciu nuo 1 iki 10");
                if (n1 > n) Console.WriteLine("Mazesnis");
                else if (n1 < n) Console.WriteLine("Didesnis");
            } while (n != n1);
            Console.WriteLine("ATSPETA!");
        }
        public string NuskaitytiString(string S)
        {
            Console.Write($"{S}: ");
            return Console.ReadLine();
        }

        public int NuskaitytiInt(string S)
        {
            return Convert.ToInt32(NuskaitytiString(S));
        }
    }
}
