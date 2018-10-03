using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Einfache Methoden
            //MachEtwas();

            //Addieren(12,6);
            //int ergebnis = Addieren(21,99);

            //Console.WriteLine(ergebnis);

            //// Tupel
            //// var mehrereWerte = MehrereWerte();
            //// Console.WriteLine(mehrereWerte.stimmt); 
            #endregion

            //int i = 50;

            //MachEtwasMitEinerZahlAlsReferenz(ref i); // ref - Schlüsselwort ist notwendig !

            //Console.WriteLine(i);


            //int zahl1 = 5;
            //int zahl2 = 5;

            #region Wertevergleich und Referenzvergleich
            //// Wertevergleich
            //if(zahl1 == zahl2)
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich");

            //int zahl3 = zahl1; // Wertekopie
            //if (zahl3 == zahl1)
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich");


            //object o = 12;
            //object o2 = 12;

            //if(o == o2) // Referenzvergleich
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich");

            //object o3 = o; // Referenzkopie
            //if (o3 == o) // Referenzvergleich
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich");


            //// Wertevergleich bei Referenztypen
            //if(o2.Equals(o3))
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich"); 
            #endregion

            object o = 21;

            ReferenzTypÜbergabe(ref o);

            o = null;
            // GC.Collect();

            //bool f = true ;
            //int ergebnis = Mehrfachausgabe(out f);

            int erg = Add(12, 5, 9);
            int erg2 = AddMitParams(12, 4);
            int erg3 = AddMitParams(12, 4,7,4,3,22,56,7,9,9,64,3,3223,45,67);


            ReadonlyReference(erg3);


            string text = "123";
            int zahl = Convert.ToInt32(text);

            // Anwendungsfall für out-parameter
            int ergebnisAusTryParse;
            if (Int32.TryParse(text, out ergebnisAusTryParse) == true)
            {
                // funktioniert ...
            }


            Console.WriteLine(erg3);
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        public static void ReadonlyReference(in int zahl) // Übergabe per referenz
        {
            //zahl = 55;
        }

        public static  int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Add(int z1, int z2, int z3)
        {
            return z1 + z2 + z3;
        }
        public static int Add(int z1, int z2, int z3, int z4)
        {
            return z1 + z2 + z3 + z4;
        }

        public static int AddMitParams(params int[] zahlen)
        {
            return zahlen.Sum();
        }

        // out -> Für eine mehrfachausgabe ohne Tupel (pre C# 7.0)
        public static int Mehrfachausgabe(out bool funktioniert)
        {
            funktioniert = false;
            return 42;
        }

        public static void ReferenzTypÜbergabe(ref object o)
        {
            // .....
        }

        // Übergabe per Referenz
        public static void MachEtwasMitEinerZahlAlsReferenz(ref int zahl)
        {
            zahl *= 2;
            Console.WriteLine(zahl);
        }

        // Übergabe per Kopie
        //public static void MachEtwasMitEinerZahl(int zahl)
        //{
        //    zahl *= 2;
        //    Console.WriteLine(zahl);
        //}



        // void -> kein ergebnis
        public static void MachEtwas()
        {
            Console.WriteLine("Mach etwas ...");
        }

        public static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        // Mehrere Werte ausgeben:
        // Tupel erst ab .NET 4.7+
        public static (bool stimmt,int zahl) MehrereWerte()
        {
            return (true, 12);
        }



    }
}
