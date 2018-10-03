namespace Polymorphie
{
    class Kreis : Grafik
    {
        public int Radius { get; set; }

        // Überschreiben
        // override -> methode aussuchen -> ENTER
        public override void Zeichnen()
        {
            //base.Zeichnen(); // originales Zeichnen
            System.Console.WriteLine($"Ein Kreis mit der Farbe {Farbe} und dem Radius {Radius} wird gezeichnet");
        }
    }
}
