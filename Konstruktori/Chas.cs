using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    public class Chas
    {
        private int chas, minuti, sekundi;

        public void Vreme() 
        {
            Console.Write("Въведете час:");
            chas = int.Parse(Console.ReadLine());
            Console.Write("Въведете минути:");
            minuti = int.Parse(Console.ReadLine());
            Console.Write("Въведете секунди:");
            sekundi = int.Parse(Console.ReadLine());
        }
        public Chas()
        {
            this.chas = 0;
            this.minuti = 0;
            this.sekundi = 0;
        }
        public Chas(int chas1, int minuti1, int sekundi1)
        {
            this.chas = chas1;
            this.minuti = minuti1;
            this.sekundi = sekundi1;
        }
        public void Izvezhdane()
        {
            Console.WriteLine($"{chas}:{minuti}:{sekundi}");
        }
    }
}
