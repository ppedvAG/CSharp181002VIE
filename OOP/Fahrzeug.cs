using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Fahrzeug
    {
        // Konstruktor: Wird aufgerufen, wenn das Objekt erstellt wird
        // ctor + TAB + TAB
        //public Fahrzeug()
        //{
        //    Kennzeichen = "MUSTERKENNZEICHEN";
        //    Kilometerstand = 20000;
        //    Geschwindigkeit = 30;
        //}
        //public Fahrzeug(string K)
        //{
        //    Kennzeichen = K;
        //    Kilometerstand = 20000;
        //    Geschwindigkeit = 30;
        //}

        public Fahrzeug(string Kennzeichen)
        {
            this.Kennzeichen = Kennzeichen;
        }

        // Destruktor: Wird aufgerufen, wenn das Objekt gelöscht wird
        ~Fahrzeug()
        {
            Console.WriteLine("Ich werde gerade aus dem Speicher gelöscht");
        }

        public string Kennzeichen { get; set; }
        public int Kilometerstand { get; protected set; }
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
