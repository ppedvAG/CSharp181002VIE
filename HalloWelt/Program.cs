using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable erstellen
            //int zahl1;
            //int z1, z2, z3;

            //int zahl2 = 50;
            //int z4 = 5, z5 = 10, z6 = 20;

            //Console.WriteLine(zahl2);

            //Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            //// int eingabe = Console.ReadLine(); 
            #endregion

            #region Konvertieren
            //// implizit Konvertieren

            //int wert1 = 50;     // Int32
            //long wert2 = 100;   // Int64

            //wert2 = wert1;      // Da Int32 kleiner als Int64 ist, ist dies erlaubt
            //// wert1 = wert2;   // Nicht erlaubt, da int Int64 etwas drinnen stehen --könnte--, was für Int32 zu groß oder zu klein ist

            //// Casten
            //wert2 = 20;         // ein gültiger Wert für Int32
            //wert1 = (int)wert2; // Konvertiert den Wert

            //// explizit Konvertieren

            //int konvertierterWert = Convert.ToInt32("12345");
            //Console.WriteLine(konvertierterWert);
            #endregion

            // cw + TAB + TAB
            // -> Code-Snippet

            // STRG + K + S   -> Codebereich umschließen


            // Übung:
            // 2 Zahlen einlesen und die Summe ausgeben

            #region Arbeiten mit Zeichenketten
            //int zahl1 = 5;
            //int zahl2 = 10;
            //int ergebnis = zahl1 + zahl2;

            //Console.WriteLine("Die Summe von " + zahl1 + " und " + zahl2 + " ist " + ergebnis);

            //// Alternative 1
            //// String.Format

            ////string text1 = string.Format("Die Summe von {0} und {1} ist {2}",zahl1,zahl2,ergebnis);
            ////Console.WriteLine(text1);
            //Console.WriteLine("Die Summe von {0} und {1} ist {2:C2}",zahl1,zahl2,ergebnis);

            //// Alternative 2
            //// String Interpolation

            //Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {zahl1+zahl2}"); 
            #endregion

            Console.ReadKey();
        }
    }
}
