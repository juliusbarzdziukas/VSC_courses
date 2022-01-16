using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.IfElse_uzduotis();
            Console.ReadKey();
        }
        public void IfElse_uzduotis()
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a < 100)
            {
                Console.WriteLine($"1. {a}>{b} && {a}<100");
            }
            if (b > 0 && b > a)
            {
                Console.WriteLine($"2. {b}>0 && {b}>{a}");
            }
            if (a > b && a > c || a > 0)
            {
                Console.WriteLine($"3. {a}>{b} && {a}>{c} || {a}>0");
            }
            if ((c >= 5 && c <= 10) || c > a || c > b)
            {
                Console.WriteLine($"4. {c} [5-10] || {c}>{a} || {c}>{b}");
            }
        }
    }
}
