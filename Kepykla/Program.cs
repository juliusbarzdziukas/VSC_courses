using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepykla
{
    class Program
    {
        static void Main(string[] args)
        {
            kepykla();
            Console.ReadKey();
        }
        static void kepykla()
        {
            Console.Write("Darbuotojo kepiniai per valanda: ");
            double kepalai_per_valanda = Convert.ToDouble(Console.ReadLine());
            Console.Write("Darbuotojai: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kepalo savikaina: ");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kepalo kaina: ");
            double kaina = Convert.ToDouble(Console.ReadLine());
            double kepalai = kepalai_per_valanda * 8.0 * darbuotojai;
            Console.WriteLine($"Kepalai per diena: {kepalai}");
            Console.WriteLine($"Kepalu savikaina: {kepalai * savikaina}");
            Console.WriteLine($"Kepalu pajamos: {kepalai * kaina}");
            Console.WriteLine($"Kepalu pelnas: {kepalai * (kaina - savikaina)}");
        }
    }
}