using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Übung:

            // 3 Klassen

            // 1) Grafik
            // Features:
            // string Farbe als Autoproperty
            // Methode Zeichnen()  ---> cw("Eine Grafik mit der Farbe {Farbe} wird gezeichnet")

            // 2) Kreis, erbt von der Grafik
            // Features:
            // int Radius als Autoproperty

            // 3) Rechteck, erbt von der Grafik
            // Features:
            // int Höhe, int Breite als Autopropertyp

            // Im Main()
            // Erstellts 1 Grafik, 1 Kreis und 1 Rechteck
            // Von jedem Objekt 1 mal Zeichnen() ausführen...

            Grafik g1 = new Grafik();
            g1.Farbe = "Rot";

            Kreis k1 = new Kreis();
            k1.Radius = 12;
            k1.Farbe = "Gelb";

            Rechteck r1 = new Rechteck();
            r1.Höhe = 33;
            r1.Breite = 44;
            r1.Farbe = "Grün";

            g1.Zeichnen();
            k1.Zeichnen();
            r1.Zeichnen();

            Console.WriteLine("------------------- Überschreiben -------------------");

            // Polymorphie:
            // Ein Objekt der Subklasse kann wie ein Objekt der Basisklasse verwendet werden

            Grafik g2 = new Kreis();
            g2.Farbe = "Lila";
            g2.Zeichnen();

            Kreis k2 = (Kreis)g2; // in wirklichkeit ist ja ein Kreis drinnen
            k2.Farbe = "Gelb";
            g2.Zeichnen();

            Console.WriteLine("------------------- Verstecken -------------------");

            Grafik g3 = new Rechteck();
            g3.Farbe = "Orange";
            g3.Zeichnen();

            Rechteck r2 = (Rechteck)g3;
            r2.Zeichnen();

            Console.WriteLine("------------------- Anwendungsbeispiel ----------------------");

            Grafik[] alleGrafiken = new Grafik[5];
            alleGrafiken[0] = g1;
            alleGrafiken[1] = k1;
            alleGrafiken[2] = r1;
            alleGrafiken[3] = k2;
            alleGrafiken[4] = new Rechteck();

            foreach (var item in alleGrafiken)
            {
                //if(item.GetType() == typeof(Rechteck))
                if (item is Rechteck)
                {
                    Console.WriteLine("Ich bin in wirklichkeit ein Rechteck");
                    Rechteck temp = (Rechteck)item;
                    temp.Zeichnen();
                }
                else
                    item.Zeichnen();
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
