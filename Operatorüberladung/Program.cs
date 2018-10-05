using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorüberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch(1, 4);
            Bruch b2 = new Bruch(1, 2);

            Bruch erg2 = b1 * b2;

            Console.WriteLine(erg2.Zähler);
            Console.WriteLine(erg2.Nenner);

            //------------------ Erweiterungsmethoden

            int zahl1 = 5;
            Console.WriteLine(zahl1.Verdoppeln());



            // Übung:
            string text = "Hallo Welt";
            Console.WriteLine(  text.Umdrehen() );

            // Eine Erweiterungsmethode für String erstellen
            // "Umdrehen" -> gibt den String komplett umgedreht zurück => "tleW ollaH"

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
