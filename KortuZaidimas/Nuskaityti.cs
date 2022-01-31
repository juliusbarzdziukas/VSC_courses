using System;

namespace KortuZaidimas
{
    internal static class Nuskaityti
    {
        public static string String(string S)
        {
            Console.Write($"{S}: ");
            return Console.ReadLine();
        }

        public static int Int(string S)
        {
            return Convert.ToInt32(Nuskaityti.String(S));
        }

        public static double Double(string S)
        {
            return Convert.ToDouble(Nuskaityti.String(S));
        }

        public static char Char(string S)
        {
            Console.Write($"{S}: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return c;
        }
        public static void PrintArray<T>(T[] a, string s)
        {
            var i = 0;
            if (i < a.Length)
            {
                Console.Write($"{a[i++]}");
            }
            for (; i < a.Length; i++)
            {
                Console.Write($"{s}{a[i]}");
            }
            Console.WriteLine();
        }
        public static void PrintArray<T>(T[] a)
        {
            Nuskaityti.PrintArray(a, ", ");
        }
    }
}