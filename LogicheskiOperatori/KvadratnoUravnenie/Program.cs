using System;

namespace KvadratnoUravnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете страна a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведете страна b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Въведете страна c:");
            int c = int.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;

            int diskriminanta = Kvadratno(a, b, c);
            if (diskriminanta > 0)
            {
                x1 = (-b + Math.Sqrt(diskriminanta)) / (2 * a);
                x2 = (-b - Math.Sqrt(diskriminanta)) / (2 * a);
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"x2: {x2}");
            }
            else if (diskriminanta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine($"x1 = x2: {x1}");
            }
            else
            {
                Console.WriteLine("Н.Р.К.");
            }

        }

        public static int Kvadratno(int a, int b, int c)
        {
            int diskriminanta = b * b - (4 * a * c);
            return diskriminanta;
        }
    }
}