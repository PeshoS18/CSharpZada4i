using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VirtualMethod
{
    public class Pet
    {
        protected string name;
        protected int age;
        public void Input()
        {
            Console.Write("Въведете име на животното:");
            name = Console.ReadLine();
            Console.Write("Въведете години на животното:");
            age = int.Parse(Console.ReadLine());

        }
        public Pet()
        {
            name = " ";
            age = 0;
        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public virtual void Info()
        {
            Console.WriteLine("Pet: unknown!");
        }
        public virtual void GetSound()
        {
            Console.WriteLine();
        }
    }
    public class Dog : Pet
    {
        private string colorDog;
        public void Input1()
        {
            Console.Write("Въведете цвят на козината на кучето:");
            colorDog = Console.ReadLine();
        }
        public string ColorDog
        {
            get { return colorDog; }
            set { colorDog = value; }
        }
        public Dog(string name, int age) : base(name, age) { }
        public override void Info()
        {
            Console.WriteLine("I'm a dog!");
        }
        public override void GetSound()
        {
            Console.WriteLine("BAU!");
        }
        public void Output()
        {
            Console.WriteLine($"Кучето има {colorDog} козина");
        }
    }
    public class Cat : Pet
    {
        private string colorCat;
        public void Input2()
        {
            Console.Write("Въведете цвят на козината на котката:");
            colorCat = Console.ReadLine();
        }
        public string ColorCat
        {
            get { return colorCat; }
            set { colorCat = value; }
        }

        public Cat(string name, int age) : base(name, age) {}
        public override void Info()
        {
            Console.WriteLine("I'm a Cat!");
        }
        public override void GetSound()
        {
            Console.WriteLine("Myau!");
        }
        public void Output()
        {
            Console.WriteLine($"Котката се казва {name} на {age} години и козината й е с цвят {colorCat}");
        }
    }
}
