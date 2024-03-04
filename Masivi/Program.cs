using System;

namespace Masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете размер на масива:");
            int razmerNaMasiv = int.Parse(Console.ReadLine());
            double[] masiv = new double[razmerNaMasiv];
            for (int i = 0; i < razmerNaMasiv; i++)
            {
                Console.Write("Въведете число:");
                masiv[i] = double.Parse(Console.ReadLine());
            }
            foreach (var item in masiv)
            {
                Console.WriteLine($"Число от масива:{item}");
            }
            for (int i = masiv.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Число от масива:{masiv[i]}");
            }
            for (int i = 0; i < masiv.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"ЧЕТНО!!!  Индекс:{i} и Число: {masiv[i]}");
                }
                else
                {
                    Console.WriteLine($"НЕЧЕТНО!  Индекс:{i} и Число: {masiv[i]}");
                }
            }
        }
    }
}