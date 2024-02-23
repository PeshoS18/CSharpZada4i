using System;

namespace YgliNaTiagalnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете страна A:");
            int strA = int.Parse(Console.ReadLine());
            Console.Write("Въведете страна B:");
            int strB = int.Parse(Console.ReadLine());
            Console.Write("Въведете страна C:");
            int strC = int.Parse(Console.ReadLine());

            if (strA == strB && strA != strC)
            {
                Console.WriteLine("Равнобедрен триъгълник!");
            }
            else if (strA != strB && strA != strC && strB != strC)
            {
                Console.WriteLine("Разностранен триъгълник!");
            }
            else if (strA == strB && strA == strC)
            {
                Console.WriteLine("Равностранен триъгълник!");
            }
            else
            {
                Console.WriteLine("Няма такава държава!");
            }
        }
    }
}