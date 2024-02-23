using System;

namespace NFactoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой:");
            var n = int.Parse(Console.ReadLine());
            var factoriel = 1;

            do
            {
                factoriel = factoriel * n;
                n--;
            } while (n > 1);
            Console.WriteLine($"Резултат:{factoriel}");
        }
    }
}