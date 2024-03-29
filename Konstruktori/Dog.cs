using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    public class Dog
    {
        private string nameDog;
        private int age;

        public void Harakteristiki()
        {
            Console.Write("Въведете име на кучето:");
            nameDog = Console.ReadLine();
            Console.Write("Въведете години на кучето:");
            age = int.Parse(Console.ReadLine());
        }
        public Dog()
        {
            this.nameDog = " ";
            this.age = 0;
        }
        public Dog(string nameDog1, int age1) 
        {
            this.nameDog = nameDog1;
            this.age = age1;
        }

        public void Izvezhdane()
        {
            Console.WriteLine($"Име на кучето:{nameDog}");
            Console.WriteLine($"Години на кучето:{age}");
        }
    }
}
