namespace Polymorphie
{
    class Rechteck : Grafik
    {
        public int Höhe { get; set; }
        public int Breite { get; set; }

        // Verstecken
        // public new void Zeichnen()  // <---- new unterdrückt die Warnung in VS, aka "ich verstecke absichtlich"
        public void Zeichnen()
        {
            System.Console.WriteLine($"Ein Rechteck mit der Farbe {Farbe}, der Höhe {Höhe} und der Breite {Breite} wird gezeichnet");
        }
    }
}
