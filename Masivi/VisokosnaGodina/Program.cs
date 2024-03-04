using System;

namespace VisokosnaGodina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] mesetsi = new string[12, 12];
            mesetsi[0, 0] = "Януари";
            mesetsi[1, 0] = "Февруари";
            mesetsi[2, 0] = "Март";
            mesetsi[3, 0] = "Април";
            mesetsi[4, 0] = "Май";
            mesetsi[5, 0] = "Юни";
            mesetsi[6, 0] = "Юли";
            mesetsi[7, 0] = "Август";
            mesetsi[8, 0] = "Септември";
            mesetsi[9, 0] = "Октомври";
            mesetsi[10, 0] = "Ноември";
            mesetsi[11, 0] = "Декември";
            mesetsi[0, 1] = "31";
            mesetsi[1, 1] = "28/29";
            mesetsi[2, 1] = "31";
            mesetsi[3, 1] = "30";
            mesetsi[4, 1] = "31";
            mesetsi[5, 1] = "30";
            mesetsi[6, 1] = "31";
            mesetsi[7, 1] = "30";
            mesetsi[8, 1] = "31";
            mesetsi[9, 1] = "30";
            mesetsi[10, 1] = "31";
            mesetsi[11, 1] = "30";
            Console.WriteLine("Месец и броя на дните в него");
            Console.WriteLine($"{mesetsi[0, 0]} - {mesetsi[0, 1]}");
            Console.WriteLine($"{mesetsi[1, 0]} - {mesetsi[1, 1]}");
            Console.WriteLine($"{mesetsi[2, 0]} - {mesetsi[2, 1]}");
            Console.WriteLine($"{mesetsi[3, 0]} - {mesetsi[3, 1]}");
            Console.WriteLine($"{mesetsi[4, 0]} - {mesetsi[4, 1]}");
            Console.WriteLine($"{mesetsi[5, 0]} - {mesetsi[5, 1]}");
            Console.WriteLine($"{mesetsi[6, 0]} - {mesetsi[6, 1]}");
            Console.WriteLine($"{mesetsi[7, 0]} - {mesetsi[7, 1]}");
            Console.WriteLine($"{mesetsi[8, 0]} - {mesetsi[8, 1]}");
            Console.WriteLine($"{mesetsi[9, 0]} - {mesetsi[9, 1]}");
            Console.WriteLine($"{mesetsi[10, 0]} - {mesetsi[10, 1]}");
            Console.WriteLine($"{mesetsi[11, 0]} - {mesetsi[11, 1]}");

            Console.Write("Въведете година:");
            int visokosnaGodina = int.Parse(Console.ReadLine());
            if (visokosnaGodina % 4 == 0)
            {
                Console.WriteLine($"Високосна година: {visokosnaGodina}");
            }
            else
            {
                Console.WriteLine($"Невисокосна година: {visokosnaGodina}");
            }
        }
    }
}