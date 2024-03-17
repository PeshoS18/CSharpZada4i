using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obekti_Metod
{
    public class Circle
    {
        private double r;

        public void VhodniDanni()
        {
            Console.Write("Въведете r:");
            r = double.Parse(Console.ReadLine());
        }
        public double AreaCircle()
        {
            double S = Math.PI * Math.Pow(r,2);
            return S;
        }
        public void DisplayThisShit()
        {
            Console.WriteLine($"Лицето на кръга е: {AreaCircle()}");
        }
    }
}
