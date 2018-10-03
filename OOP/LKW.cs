using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class LKW : Fahrzeug
    {
        public LKW(string Kennzeichen) : base(Kennzeichen)
        {
        }

        public double Höhe { get; set; }
        public int MaxLadegewicht { get; set; }

        public void Demo()
        {
            var x = Kennzeichen + "lalalalal";
            Kilometerstand += 20;
        }
    }
}
