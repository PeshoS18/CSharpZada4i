using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obekti_Metod
{
    public class Triangle
    {
        private int strA;
        private int strB;
        private int strC;

        public void VhodniDanni()
        {
            Console.Write("Въведете срана а:");
            strA = int.Parse(Console.ReadLine());
            Console.Write("Въведете срана b:");
            strB = int.Parse(Console.ReadLine());
            Console.Write("Въведете срана c:");
            strC = int.Parse(Console.ReadLine());
        }
        public int AreaTriangle()
        {
            int p = (strA + strB + strC) / 2;
            int S = (int)Math.Sqrt(p * (p * strA) * (p * strB) * (p * strC));
            return S;
        }
        public void DisplayThisShit()
        {
            Console.WriteLine($"Лицето на триъгълника е: {AreaTriangle()}");
        }
    }
}
