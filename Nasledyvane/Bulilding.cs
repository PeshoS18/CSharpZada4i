using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledyavane
{
    public class Building
    {
        protected double height, area;
        protected string adress;
        public void Input1()
        {
            Console.WriteLine("Данни за сградата");
            Console.Write("Въведете височина:");
            height = double.Parse(Console.ReadLine());
            Console.Write("Въведете площ:");
            area = double.Parse(Console.ReadLine());
            Console.Write("Въведете адрес:");
            adress = Console.ReadLine();
        }
        public Building() { }
        public Building(double height, double area,string adress) 
        {
            this.height = height;
            this.area = area;
            this.adress = adress;
        }
        public void Output1()
        {
            Console.WriteLine($"Сградата е висока {height}, площта и е {area} и адреса и е {adress}.");
        }
    }
    public class House : Building 
    {
        protected int brEtazhi;
        protected string imeSobstvenik;
        public int BrEtazhi
        {
            get { return brEtazhi; }
            set { brEtazhi = value; }
        }
        public string ImeSobstvenik
        {
            get { return imeSobstvenik; }
            set { imeSobstvenik = value; }
        }
        public void Input2()
        {
            Console.Write("Въведете брой на етажите:");
            brEtazhi = int.Parse(Console.ReadLine());
            Console.Write("Въведете име на собственика:");
            imeSobstvenik = Console.ReadLine();
        }
        public House(): base() { }
        public House(double height, double area, string adress, int brEtazhi, string imeSobstvenik) : base(height, area, adress)
        {
            this.brEtazhi = brEtazhi;
            this.imeSobstvenik = imeSobstvenik;
        }
        public void Output2()
        {
            Console.WriteLine($"Къщата има {brEtazhi} и собственика й е {imeSobstvenik}.");
        }
    }
}
