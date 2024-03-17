using System;
using System.Drawing;

namespace Obekti_Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изберете:\n1-Триъгълник\n2-Триъгълник\n3-Кръг");
            int izbor = int.Parse(Console.ReadLine());
            switch (izbor)
            {
                case 1:
                    Rect firstRect = new Rect();
                    firstRect.VhodniDanni();
                    firstRect.DisplayThisShit();
                    break;
                case 2:
                    Triangle firstTriangle = new Triangle();
                    firstTriangle.VhodniDanni();
                    firstTriangle.DisplayThisShit();
                    break;
                case 3:
                    Circle firstCircle = new Circle();
                    firstCircle.VhodniDanni();
                    firstCircle.DisplayThisShit();
                    break;
                default:
                    break;
            }
        }
    }
}