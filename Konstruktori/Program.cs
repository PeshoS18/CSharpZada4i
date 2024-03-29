using System;

namespace Konstruktori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Изберете задача:\n1-Куче\n2-Час\n3-Фигури\n4-Студент");
            int izbor1 = int.Parse(Console.ReadLine());
            switch (izbor1)
            {
                case 1:
                    Dog dog1 = new Dog();
                    Dog dog2 = new Dog();
                    Dog dog3 = new Dog();

                    dog1.Harakteristiki();
                    dog1.Izvezhdane();
                    dog2.Harakteristiki();
                    dog2.Izvezhdane();
                    dog3.Harakteristiki();
                    dog3.Izvezhdane();
                    break;
                case 2:
                    Chas chas1 = new Chas();

                    chas1.Vreme();
                    chas1.Izvezhdane();
                    break;
                case 3:
                    Console.WriteLine("Изберете фигура:\n1-Правоъгълник\n2-Кръг\n3-Квадрат");
                    int izbor2 = int.Parse(Console.ReadLine());
                    switch (izbor2)
                    {
                        case 1:
                            Rectangle rect1 = new Rectangle();
                            rect1.Razmer();
                            rect1.Plosht();
                            rect1.Izvezhdane1();
                            break;
                        case 2:
                            Circle circle1 = new Circle();
                            circle1.Razmer();
                            circle1.Radius();
                            circle1.Izvezhdane2();
                            break;
                        case 3:
                            Square square1 = new Square();
                            square1.Razmer();
                            square1.Plosht();
                            square1.Izvezhdane3();
                            break;
                    }
                    break;
                case 4:
                    Student student1 = new Student();

                    student1.VhodniDanni();
                    student1.Izvezhdane();
                    break;
            }
        }
    }
}