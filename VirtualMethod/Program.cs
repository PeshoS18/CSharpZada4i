using System;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet myPet;

            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1: myPet = new Dog(" ",-8);
                    myPet.Info();
                    myPet.GetSound();
                    break;
                case 2: myPet = new Cat(" ",99);
                    myPet.Info();
                    myPet.GetSound();
                    break;
                default:
                    myPet = new Pet();
                    break;
            }
        }
    }
}
