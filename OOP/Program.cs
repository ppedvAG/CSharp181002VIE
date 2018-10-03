using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person v1
            //Person p1;                  // Deklaration
            //Person p2 = new Person();   // Deklaration + Initialisierung

            //p2.vorname = "Tom";
            //p2.nachname = "Ate";

            //p1 = new Person();

            //p1.vorname = "Anna";
            //p1.nachname = "Nass";
            //p1.alter = 250;
            //p1.kontostand = -20000000;

            //Console.WriteLine(p1.nachname); 
            #endregion

            #region Exception
            //Console.WriteLine("Bitte geben Sie eine Zahl ein");

            //int zahl1 = 0;
            ////try
            ////{
            ////    zahl1 = Convert.ToInt32(Console.ReadLine());
            ////}
            ////catch(FormatException) // Jede Exception
            ////{
            ////    Console.WriteLine("Bitte keine Buchstaben und Sonderzeichen eingeben ! ...");
            ////}
            ////catch (OverflowException) // Jede Exception
            ////{
            ////    Console.WriteLine("Ihre Zahl ist zu groß oder zu klein ...");
            ////}

            //// Schnelles Erstellen von einem Try/Catch - Block
            //// try + TAB + TAB


            //try
            //{
            //    zahl1 = Convert.ToInt32(Console.ReadLine());

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine(zahl1*2); 
            #endregion

            // Übung:
            // 1 + 2 + 3 .... N

            // -> Programm absichern, damit keine Exceptions passieren können


            #region Person v2
            ////Person p1 = new Person();
            ////p1.vorname = "Tom";
            ////p1.nachname = "Ate";
            ////p1.alter = 50;
            ////p1.Kontostand = -5000;

            ////Console.WriteLine(p1.Kontostand); 
            #endregion
            #region Fahrzeug
            //Fahrzeug audi = new Fahrzeug();
            //audi.Kennzeichen = "W12345";
            //audi.Geschwindigkeit = 500;
            //Console.WriteLine(audi.Geschwindigkeit); // sollte bei 250 sein

            //audi.Geschwindigkeit = 10;

            //Console.WriteLine(audi.Geschwindigkeit); // sollte bei 10 sein;

            //Console.WriteLine(audi.Kilometerstand);
            //audi.Fahren(5);
            //Console.WriteLine(audi.Kilometerstand);

            //Console.WriteLine(audi.Kilometerstand);
            //audi.Fahren(-7);
            //Console.WriteLine(audi.Kilometerstand); 
            #endregion

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
    #region ReadOnlyProperty
    //class Person2
    //{
    //    // ReadOnlyProperty

    //    private string vorname;
    //    private string nachname;

    //    public string GanzerName
    //    {
    //        get
    //        {
    //            return vorname + " " + nachname;
    //        }
    //    }
    //} 
    #endregion
}
