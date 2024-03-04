using System;

namespace PolozhitelenMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете размер на масива:");
            int razmerNaMasiv = int.Parse(Console.ReadLine());
            int[] masiv = new int[razmerNaMasiv];
            int[] masiv2;

            for (int i = 0; i < razmerNaMasiv; i++)
            {
                Console.Write("Въведете число:");
                masiv[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in masiv)
            {
                Console.WriteLine($"Число: {item}");
            }
            Console.WriteLine("Положителни числа");

            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i] > 0)
                {
                    masiv2 = masiv;
                    Console.WriteLine($"Число: {masiv2[i]}");
                }
            }
        }
    }
}