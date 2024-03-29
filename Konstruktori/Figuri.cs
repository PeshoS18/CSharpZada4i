using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    public class Figuri
    {
    }
    public class Rectangle
    {
        private double strA, strB, p;
        public void Razmer()
        {
            Console.Write("Въведете страна а:");
            strA = double.Parse(Console.ReadLine());
            Console.Write("Въведете страна b:");
            strB = double.Parse(Console.ReadLine());
        }
        public Rectangle()
        {
            this.strA = 0;
            this.strB = 0;
        }
        public Rectangle(double strA,double strB)
        {
            this.strA = strA;
            this.strB = strB;
        }
        public double Plosht()
        {
            return p = strA * strB;
        }
        public void Izvezhdane1()
        {
            Console.WriteLine($"Площта е:{p}");
        }
    }
    public class Circle
    {
        private double radius;
        public void Razmer()
        {
            Console.Write("Въведете радиус:");
            radius = double.Parse(Console.ReadLine());
        }
        public Circle() 
        {
            this.radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius()
        {
            return radius = Math.PI * Math.Pow(radius,2);
        }
        public void Izvezhdane2()
        {
            Console.WriteLine($"Площта е:{radius}");
        }
    }
    public class Square
    {
        private double strA;
        public void Razmer()
        {
            Console.Write("Въведете страна а:");
            strA = double.Parse(Console.ReadLine());
        }
        public Square()
        {
            this.strA = 0;
        }
        public Square(double strA)
        {
            this.strA = strA;
        }
        public double Plosht()
        {
            return strA *= strA;
        }
        public void Izvezhdane3()
        {
            Console.WriteLine($"Площта е:{strA}");
        }
    }
}
