using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    // sealed class -> Man darf von dieser Klasse nicht mehr erben !
    sealed class Jugendkonto : Konto
    {
        // sealed verhindert, dass eine subklasse die Methode überschreiben kann
        public sealed override void Abheben(decimal Betrag)
        {
            // Darf nicht unter 0
            if(Betrag > 0)
            {
                if (Kontostand - Betrag > 0)
                    Kontostand -= Betrag;
                else
                    Console.WriteLine("Sie dürfen nicht mehr Abheben als Sie besitzen.");
            }
            else
                Console.WriteLine("Betrag ist ungültig");
        }

        public override void PinÄndern()
        {
            throw new NotImplementedException();
        }
    }


    //class SpezialKinderKonto : Jugendkonto
    //{
    //    public void Abheben(decimal Betrag)
    //    {
    //        base.Abheben(Betrag);
    //    }
    //}
}
