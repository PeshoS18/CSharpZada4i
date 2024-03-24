using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StatichniMetodi
{
    public class TochkaVRavnina
    {
        private int x, y;

        public void Input()
        {
            Console.Write("Въведете x:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Въведете y:");
            y = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public static double Distance(TochkaVRavnina nachalo, TochkaVRavnina krai)
        {
            int dnachalo, dkrai;
            dnachalo = nachalo.x - krai.x;
            dkrai = nachalo.y - krai.y;
            double l = Math.Sqrt(dnachalo * dnachalo + dkrai * dkrai);
            return l;
        }
    }
}
