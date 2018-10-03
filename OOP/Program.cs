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

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
