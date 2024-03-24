using System;

namespace StatichniMetodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TochkaVRavnina tochka1 = new TochkaVRavnina();
            TochkaVRavnina tochka2 = new TochkaVRavnina();

            tochka1.Input();
            tochka1.Output();
            tochka2.Input();

            double l = TochkaVRavnina.Distance(tochka1, tochka2);
            Console.WriteLine($"Нещо:{l}");
        }
    }
}