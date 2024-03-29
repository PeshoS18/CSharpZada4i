using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    public class Student
    {
        private string studentName, spetsialnost;
        private int facNomer, kurs;

        public void VhodniDanni() 
        {
            Console.Write("Въведете три имена: ");
            studentName = Console.ReadLine();
            Console.Write("Въведете факултетен номер: ");
            facNomer = int.Parse(Console.ReadLine());
            Console.Write("Въведете специалност: ");
            spetsialnost = Console.ReadLine();
            Console.Write("Въведете курс: ");
            kurs = int.Parse(Console.ReadLine());
        }
        public Student()
        {
            this.studentName = " ";
            this.facNomer = 0;
            this.spetsialnost = " ";
            this.kurs = 0;
        }
        public Student(string studentName1, string spetsialnost1, int facNomer1, int kurs1)
        {
            this.studentName = studentName1;
            this.spetsialnost = spetsialnost1;
            this.facNomer = facNomer1;
            this.kurs = kurs1;
        }
        public void Izvezhdane()
        {
            Console.WriteLine($"Трите имена на студента: {studentName}");
            Console.WriteLine($"Специалност: {spetsialnost}");
            Console.WriteLine($"Факултетен номер: {facNomer}");
            Console.WriteLine($"Курс: {kurs}");
        }
    }
}
