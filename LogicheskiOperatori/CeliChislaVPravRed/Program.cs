using System;

namespace CeliChislaVPravRed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 числа: ");
            int[] masiv = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Число: ");
                masiv[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(masiv[i]);
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(masiv[i]);
            }
        }
    }
}