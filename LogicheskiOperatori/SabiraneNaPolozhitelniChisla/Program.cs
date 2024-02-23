using System;
using System.Threading.Channels;

namespace SabiraneNaPolozhitelniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число:");
            int chislo = int.Parse(Console.ReadLine());
            int resultat = 0;
            int i=0;
            while (chislo > 0 && chislo != 0)
            {
                resultat += chislo;
                Console.Write("Въведете следващо число:");
                chislo = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"Резултат: {resultat}");
        }
    }
}