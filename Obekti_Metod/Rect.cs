using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obekti_Metod
{
    public class Rect
    {
        private int height;
        private int width;

        public void VhodniDanni()
        {
            Console.Write("Въведете височина:");
            height = int.Parse(Console.ReadLine());
            Console.Write("Въведете ширина:");
            width = int.Parse(Console.ReadLine());
        }
        public int Area()
        {
            return height * width;
        }
        public void DisplayThisShit()
        {
            Console.WriteLine($"Височиата е {height}, ширината е {width}, а обиколката на правоъгълника е {Area()}");
        }
    }
}
