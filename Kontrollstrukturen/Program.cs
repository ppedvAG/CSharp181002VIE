using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {

        enum Wochentage { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag };

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

            #region Tenärer Operator
            //string text;
            //int zahl = 1;

            //if (zahl > 0)
            //    text = "größer als 0";
            //else
            //    text = "kleiner als 0";

            ////            (Bedingung) ? true-Fall : false-Fall
            //string text2 = (zahl > 0) ? "größer" : "kleiner"; 
            #endregion

            #region Arrays
            //int[] meineZahlen = new int[5]; // 5 Variablen, durchnummeriert von 0-4
            //meineZahlen[0] = 5;
            //meineZahlen[1] = 9;
            //meineZahlen[2] = 12;
            //meineZahlen[3] = 77;
            //meineZahlen[4] = 3;


            //Console.WriteLine(meineZahlen[2]);

            //int[,] schachbrett = new int[8, 8];
            //schachbrett[2, 2] = 22;

            ////object[] datentypen = new object[2];
            ////datentypen[0] = new int[5];
            ////datentypen[1] = new string[5];

            ////(datentypen[0] as int[])[1] = 12;
            ////(datentypen[1] as string[])[1] = "abcde";

            //// Initialisieren
            //string[] meineTexte = new string[] { "Hallo", "Welt", "!" };
            //string[] meineTexte2 = { "Hallo", "Welt", "!" };

            //// Vergrößern:
            //// string[] größer = new string[1000];
            //// Array.Copy(meineTexte, größer, meineTexte.Length); 
            #endregion

            #region ForEach

            // int[] meineZahlen = { 12, 56, 8, 9, 43, 2, 2, 46, 7, 90, 0, 98765, 32, 2, 5, 67, 9 };

            ////for (int i = 0; i < meineZahlen.Length; i++)
            ////{
            ////    Console.WriteLine(meineZahlen[i]);
            ////}

            //foreach (var zahl in meineZahlen)
            //{
            //    Console.WriteLine(zahl);
            //} 
            #endregion

            // Übung:
            // Lottozahlengenerator
            // Array erstellen für 6 int-zahlen
            // in einer schleife 6 mal r.Next(1,45) aufrufen und das array füllen
            // am ende: alle zahlen schön in der Konsole ausgeben
            // "Ihre Lottozahlen: 5,7,3,2,6,45" ....

            // Bonus: Überprüfen, dass keine Zahl doppelt vorkommt
            // meineZahlen.Contains(12); <--- Überprüft, ob die zahl 12 schon vorhanden ist

            #region Übung
            //Random r = new Random();
            //int[] lotto = new int[6];

            //for (int i = 0; i < lotto.Length; i++)
            //{
            //    //int neueZahl = r.Next(0, 45);
            //    //if (lotto.Contains(neueZahl) == false)
            //    //    lotto[i] = neueZahl;
            //    //else // bereits vorhanden
            //    //    i--;

            //    int neuezahl = 0;
            //    do
            //    {
            //        neuezahl = r.Next(0, 45);
            //    } while (lotto.Contains(neuezahl));

            //    lotto[i] = neuezahl;
            //}

            //Console.Write("Deine Lottozahlen sind:");
            //foreach (var item in lotto)
            //{
            //    Console.Write($"{item},");
            //} 
            #endregion


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
