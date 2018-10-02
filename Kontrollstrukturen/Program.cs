using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {

        enum Wochentage { Montag,Dienstag,Mittwoch,Donnerstag,Freitag,Samstag,Sonntag};

        static void Main(string[] args)
        {
            #region Pre/Post Increment
            //int zahl1 = 5;
            //int zahl2 = 10;

            ////zahl1++; // Post-Increment
            ////++zahl1; // Pre-Increment

            //zahl2 = zahl1++;

            //Console.WriteLine(zahl2);
            //Console.WriteLine(zahl1); 
            #endregion

            #region IF
            //int zahl1 = 5;
            //int zahl2 = 10;

            //if(zahl1 > zahl2)
            //{
            //    Console.WriteLine("größer");
            //}
            //else if(zahl1 == zahl2)
            //{
            //    Console.WriteLine("gleich groß");
            //}
            //else
            //{
            //    Console.WriteLine("kleiner");
            //}

            //// Verknüpfungsoperatoren
            //// |  - OR  , &  - AND  <--- Schaut sich IMMER beide Bedingungen an 
            //// || - OR  , && - AND  <--- Kurzschlussoperator, schaut sich nicht die 2te Bedingung an, wenn das Ergebnis nach der ersten schon feststeht 
            #endregion

            #region Switch
            //int zahl1 = 5;

            //switch (zahl1)
            //{
            //    case 1:
            //        Console.WriteLine("Eins");
            //        break;
            //    case 2:
            //        Console.WriteLine("Zwei");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Drei, Vier oder Fünf");
            //        break;
            //    default:
            //        Console.WriteLine("Alles andere");
            //        break;
            //}

            //Wochentage heute = Wochentage.Dienstag;
            //if(heute == Wochentage.Sonntag)
            //    Console.WriteLine(" 8) ");

            //switch (heute)
            //{
            //    case Wochentage.Montag:
            //        break;
            //    case Wochentage.Dienstag:
            //        break;
            //    case Wochentage.Mittwoch:
            //        break;
            //    case Wochentage.Donnerstag:
            //        break;
            //    case Wochentage.Freitag:
            //        break;
            //    case Wochentage.Samstag:
            //        break;
            //    case Wochentage.Sonntag:
            //        break;
            //    default:
            //        break;
            //} 
            #endregion

            // Übung:
            // Random r = new Random(); // Zufallszahlengenerator
            // Neue Zahl:
            // int neue = r.Next(0, 100); // von 0 bis 100

            // 1) Zufallszahl erstellen
            // 2) User muss ebenfalls eine Zahl eingeben
            // 3) Ausgabe, ob die eingegebene Zahl größer oder kleiner ist
            //  ----> Nur 1 Mal (schleifen kommen noch ;) )

            // ----------------- Schleifen ------------------

            // Zählergesteuerte Schleife
            //for(startwert ; bedingung ; aktualisierung)
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Bedingungsgesteuerte Schleife
            //string eingabe = "";

            //while(eingabe != "q") // Kopfgesteuert
            //{
            //    Console.WriteLine("Bitte geben Sie etwas ein: ");
            //    eingabe = Console.ReadLine();
            //    Console.WriteLine($"Ihre Eingabe war: {eingabe}");
            //}


            //do
            //{

            //} while (eingabe != "q"); // Fußgesteuert


            #region Übung - Schleifen
            //// > "Bitte geben Sie eine Zahl ein"
            //// > 5
            //// > -> 1 + 2 + 3 .... 5
            //// > "Die Summe von 1 bis {eingabe} ist {summe} // bei 5 -> 15


            //Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            //int eingabe = Convert.ToInt32(Console.ReadLine());

            //int summe = 0;
            //for (int i = 1; i <= eingabe; i++)
            //{
            //    summe += i;
            //}
            //Console.WriteLine($"Die Summe von 1 bis {eingabe} ist {summe}"); 
            #endregion

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
