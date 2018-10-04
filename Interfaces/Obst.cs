using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Obst : IProdukt
    {
        public Obst(string herkunft, string name, int kcal, decimal preis)
        {
            Herkunft = herkunft;
            Name = name;
            Kcal = kcal;
            Preis = preis;
        }

        public string Herkunft { get; set; }
        public string Name { get; set; }
        public int Kcal { get; set; }
        public decimal Preis { get; set; }
    }
}
