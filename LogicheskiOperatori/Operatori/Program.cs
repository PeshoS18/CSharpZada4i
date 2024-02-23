using System;

namespace Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете а:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведете b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Изберете:\n 1:+\n 2:-\n 3:*\n 4:/");

            char izbor = char.Parse(Console.ReadLine());
            double result;
            switch (izbor)
            {
                case '+':
                    result = a + b;
                    if (a == 0 && b == 0)
                    {
                        Console.WriteLine("0");
                    }
                    Console.WriteLine($"Резултат: {result}");
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine($"Резултат: {result}");
                    break;
                case '*':
                    result = a * b;
                    if (a == 0 || b == 0)
                    {
                        Console.WriteLine("Не може да се умножава с 0");
                    }
                    Console.WriteLine($"Резултат: {result}");
                    break;
                case '/':
                    result = a / b;
                    if (a != 0 ^ b != 0)
                    {
                        Console.WriteLine("Логическо изключващо или");
                    }
                    Console.WriteLine($"Резултат: {result}");
                    break;
            }
        }
    }
}