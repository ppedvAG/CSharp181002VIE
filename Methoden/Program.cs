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
            MachEtwas();

            Addieren(12,6);
            int ergebnis = Addieren(21,99);

            Console.WriteLine(ergebnis);

            // Tupel
            // var mehrereWerte = MehrereWerte();
            // Console.WriteLine(mehrereWerte.stimmt);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

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
