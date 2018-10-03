using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    // Abstract verhindert, dass man Objekte von einer Klasse erstellen kann
    abstract class Konto
    {
        public string Inhaber { get; set; }
        public decimal Kontostand { get; protected set; }

        public virtual void Abheben(decimal Betrag)
        {
            if (Betrag > 0)
                Kontostand -= Betrag;
            else
                Console.WriteLine("Betrag ist ungültig");
        }

        public virtual void Einzahlen(decimal Betrag)
        {
            if (Betrag > 0)
                Kontostand += Betrag;
            else
                Console.WriteLine("Betrag ist ungültig");
        }

        // Abstrakte Methode: 
        // Bestimmt, dass es in einer Subklasse eine Methode geben MUSS
        // Die Implementierung hängt von der Subklasse ab
        public abstract void PinÄndern();
    }
}
