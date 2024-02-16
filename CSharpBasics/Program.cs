using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tsenaZaVIPBileti = 497.54;
            Console.WriteLine($"Цена на VIP билети:{tsenaZaVIPBileti}");
            double tsenaZaNormalniBileti = 245.80;
            Console.WriteLine($"Цена на нормални билети:{tsenaZaNormalniBileti}");
            Console.WriteLine("Брой хора:");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Бюджет:");
            double byudzhet = double.Parse(Console.ReadLine());
            double byudzhetSledPreravnyavane = 0;

            if (hora >= 1 && hora <= 4)
            {
                byudzhetSledPreravnyavane = byudzhet * 0.75;

            }
            else if (hora >= 5 && hora <= 9)
            {
                byudzhetSledPreravnyavane = byudzhet * 0.60;
            }
            else if (hora >= 10 && hora <= 24)
            {
                byudzhetSledPreravnyavane = byudzhet * 0.50;
            }
            else if (hora >= 25 && hora <= 49)
            {
                byudzhetSledPreravnyavane = byudzhet * 0.40;
            }
            else if (hora > 50)
            {
                byudzhetSledPreravnyavane = byudzhet * 0.25;
            }
            else
            {
                Console.WriteLine("Няма хора");

            }

            Console.WriteLine($"Крайни пари:{byudzhetSledPreravnyavane}");

            if (byudzhetSledPreravnyavane >= tsenaZaVIPBileti)
            {
                Console.WriteLine("Парите стигат за VIP!");
            }
            else if (byudzhetSledPreravnyavane <= tsenaZaVIPBileti)
            {
                Console.WriteLine("Не стигат парите за VIP!");
                Console.WriteLine("Има достатъчно пари за нормални билети!");
            }
            else
            {
                Console.WriteLine("Няма достатъчно пари за нормални билети!");
            }
        }
    }
}