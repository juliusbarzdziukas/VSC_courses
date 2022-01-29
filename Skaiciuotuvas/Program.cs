using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Skaiciuotuvas();
        }

        public void Skaiciuotuvas()
        {
            char c;
            do
            {
                double n1 = NuskaitytiDouble("N1");
                double n2 = NuskaitytiDouble("N2");
                c = NuskaitytiChar("Operacija (+-*/%)");
                switch (c)
                {
                    case '+':
                        Console.WriteLine($"{n1 + n2}");
                        break;
                    case '-':
                        Console.WriteLine($"{n1 - n2}");
                        break;
                    case '*':
                        Console.WriteLine($"{n1 * n2}");
                        break;
                    case '/':
                        Console.WriteLine($"{n1 / n2}");
                        break;
                    case '%':
                        Console.WriteLine($"{n1 % n2}");
                        break;
                    default:
                        Console.WriteLine($"Bloga operacija: {c}");
                        break;
                }
                c = NuskaitytiChar("Ar testi? T (Taip)");
            } while (c == 't' || c == 'T');
        }

        public string NuskaitytiString(string S)
        {
            Console.Write($"{S}: ");
            return Console.ReadLine();
        }

        public double NuskaitytiDouble(string S)
        {
            return Convert.ToDouble(NuskaitytiString(S));
        }

        public char NuskaitytiChar(string S)
        {
            Console.Write($"{S}: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return c;
        }
    }
}
