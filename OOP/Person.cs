using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        #region Gültigkeitsspezifizierer
        //// public       -> Überall sichtbar
        //// private      -> Nur in der eigenen Klasse sichtbar
        //// protected    -> Nur in der eigenen Klasse und allen Klassen, die davon erben, sichtbar

        //// internal     -> Nur in der eigenen Assembly sichtbar
        //// protected interna -> Mischung aus protected und internal

        //// C#7.2:
        //// private protected -> Protected, das nur in der eigenen Assembly gilt, ansonsten private 
        #endregion

        #region Property - ALT
        //private decimal kontostand;
        //public void KontostandSetzen(decimal neuerKontostand)
        //{
        //    if (neuerKontostand >= -10000 && neuerKontostand <= 1000000)
        //        kontostand = neuerKontostand;
        //    else
        //        throw new Exception("Wert ist für den Kontostand ungültig");
        //}
        //public decimal KontostandAuslesen()
        //{
        //    return kontostand;
        //} 
        #endregion

        private decimal kontostand;
        public decimal Kontostand
        {
            get // Lesezugriff
            {
                return kontostand;
            }
           private  set // Schreibzugriff
            {
                if (value >= -10000 && value <= 1000000)
                    kontostand = value;
                else
                    throw new Exception("Wert ist für den Kontostand ungültig");
            }
        }


        // propfull + TAB + TAB
        private byte alter;
        public byte Alter
        {
            get { return alter; }
            set { alter = value; }
        }

        // Autoproperty:
        // prop + TAB + TAB

        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }

    // Übung:
    // Neue Klasse: Fahrzeug
    // Eigenschaften:

    // int Geschwindigkeit -> Set: Beschränkung auf 0 - 250
    //                     -> wenn größer -> cap 250, wenn kleiner -> cap auf 0
    // int Kilometerstand: Schreibzugriff privat
    // string Kennzeichen (autoproperty)

    // Methode Fahren
    // > public void Fahren (int Stunden)    => Kilometerstand erhöht sich um die gefahrenen km (
    // Bonus: ---- > Achtung: Alle Fehler abfangen !
}
