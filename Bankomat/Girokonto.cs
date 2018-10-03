using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    // partial class -> Klassendefinition kann auf mehrere Dateien aufgeteilt werden
    partial class Girokonto : Konto
    {
        public int zahl1 { get; set; }
        public int zahl2 { get; set; }

        public override void PinÄndern()
        {
            throw new NotImplementedException();
        }
    }
}
