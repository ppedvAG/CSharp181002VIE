using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Fahrzeug
    {

        public string Kennzeichen { get; set; }
        public int Kilometerstand { get; private set; }

        private int geschwindigkeit;

        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set
            {
                if (value > 250)
                    geschwindigkeit = 250;
                else if (value < 0)
                    geschwindigkeit = 0;
                else
                    geschwindigkeit = value;
            }
        }

        public void Fahren(int Stunden)
        {
            if (Stunden > 0)
                Kilometerstand += Geschwindigkeit * Stunden;
            else
                throw new Exception("Stundenwert ist ungültig");
        }
    }
}
