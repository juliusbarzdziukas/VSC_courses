using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spalvos
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Spalvos();
            Console.ReadKey();
        }
        public void Spalvos()
        {
            Console.Write("Vardas: ");
            string vardas=Console.ReadLine();
            Console.Write("Amzius: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skaicius: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Vardas: {vardas}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Amzius: {amzius}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Skaicius: {skaicius}");
            Console.ResetColor();
        }

    }
}
