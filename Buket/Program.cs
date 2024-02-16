using System;

namespace Buket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chervenaRoza = 7.89;
            Console.WriteLine($"Цена за една червена роза:{chervenaRoza}");
            double lale = 5.89;
            Console.WriteLine($"Цена за едно лале:{lale}");
            double orhideya = 45.32;
            Console.WriteLine($"Цена за една орхидея: {orhideya}");
            double aranzhirane = 5.00;
            Console.WriteLine($"Цена за аранжиране на букет: {aranzhirane}");
            Console.WriteLine("Брой червени рози:");
            int broiCherveniRozi = int.Parse(Console.ReadLine());
            Console.WriteLine("Брой лалета:");
            int broiLaleta = int.Parse(Console.ReadLine());
            Console.WriteLine("Брой орхидеи:");
            int broiOrhidei = int.Parse(Console.ReadLine());
            double krainaSuma = 0;
            int obshtBroiTsvetya = broiCherveniRozi + broiLaleta + broiOrhidei;

            Console.WriteLine("Изберете повод/сезон: \n1-св.Валентин\n2-Пролет\n3-Лято");
            int povod_sezon = int.Parse(Console.ReadLine());

            switch (povod_sezon)
            {
                case 1:
                    krainaSuma = (((broiCherveniRozi * chervenaRoza) + (broiLaleta * lale) + (broiOrhidei * orhideya)) + aranzhirane) * 0.85;
                    if (obshtBroiTsvetya >= 22)
                    {
                        krainaSuma *= 0.77;
                    }
                    Console.WriteLine($"Крайна сума:{krainaSuma}");
                    break;
                case 2:
                    krainaSuma = ((broiCherveniRozi * chervenaRoza) + (broiLaleta * lale) + (broiOrhidei * orhideya)) + aranzhirane;
                    if (broiLaleta >= 3)
                    {
                        krainaSuma *= 0.95;
                    }
                    if (obshtBroiTsvetya >= 22)
                    {
                        krainaSuma *= 0.77;
                    }
                    Console.WriteLine($"Крайна сума:{krainaSuma}");
                    break;
                case 3:
                    krainaSuma = ((broiCherveniRozi * chervenaRoza) + (broiLaleta * lale) + (broiOrhidei * orhideya)) + aranzhirane;
                    if (broiCherveniRozi == 12)
                    {
                        krainaSuma *= 0.90;
                    }
                    if (obshtBroiTsvetya >= 22)
                    {
                        krainaSuma *= 0.77;
                    }
                    Console.WriteLine($"Крайна сума:{krainaSuma}");
                    break;
                default:

                    break;
            }
        }
    }
}