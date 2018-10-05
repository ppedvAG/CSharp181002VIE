using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IchBraucheKeineSchleifenMehr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personen = new List<Person>
            {
                new Person{Vorname="Tom", Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna", Nachname="Nass",Alter=20,Kontostand=2000},
                new Person{Vorname="Peter", Nachname="Silie",Alter=30,Kontostand=3},
                new Person{Vorname="Franz", Nachname="Ose",Alter=40,Kontostand=-1000},
                new Person{Vorname="Martha", Nachname="Pfahl",Alter=50,Kontostand=5000000},
                new Person{Vorname="Klara", Nachname="Fall",Alter=60,Kontostand=123456},
                new Person{Vorname="Bill", Nachname="Dung",Alter=70,Kontostand=-987654},
                new Person{Vorname="Frank N", Nachname="Stein",Alter=80,Kontostand=-5235},
                new Person{Vorname="Anna", Nachname="Bolika",Alter=90,Kontostand=20000000},
                new Person{Vorname="Axel", Nachname="Schweiß",Alter=100,Kontostand=639365},
            };

            #region Aufgaben mit Schleife
            //// Aufgabe: Von allen Personen den Vornamen in einer neuen Liste speichern
            //List<string> alleVornamen = new List<string>();
            //foreach (var item in personen)
            //{
            //    alleVornamen.Add(item.Vorname);
            //}

            //// Aufgabe 2: Von allen Personen, die einen negativen Kontostand haben, den Vornamen in einer liste speichern
            //List<string> alleVornamenMitNegativemKontostand = new List<string>();
            //foreach (var item in personen)
            //{
            //    if(item.Kontostand <= 0)
            //        alleVornamen.Add(item.Vorname);
            //}

            //// Aufgabe 3: Alle Personen-Objekte, die einen negativen Kontostand haben in einer neuen Liste nach Alter sortiert abspeichern
            //// .... 
            #endregion


            // Liste mit allen Vornamen

            // SELECT -> Von einem element X den wert Y zurückgeben will
            List<string> alleNamen = personen.Select(x => $"{x.Vorname} {x.Nachname}").ToList();

            // WHERE -> Filterbedingung (if)
            string[] alleNamenMitNegativemKontostand = personen.Where(x => x.Kontostand < 0)
                                                                   .Select(x => x.Vorname)
                                                                   .ToArray();

            // ORDERBY -> Sortieren (es gibt auch ORDERBYDESCENDING)
            Person[] allePersonenMitNegativemKontostandSortiertNachAlter = personen.Where(x => x.Kontostand < 0)
                                                                                   .OrderBy(x => x.Alter)
                                                                                   .ToArray();

            // FIRST -> nimmt sich das erste Element aus einer Liste heraus
            Person personMitHöchstemKontostand = personen.OrderByDescending(x => x.Kontostand).First();

            // SUM -> Berechnet sich die Summe für alle Elemente der Liste
            decimal alleSchulden = personen.Where(x => x.Kontostand < 0).Select(x => x.Kontostand).Sum();

            /* Aufgaben:
             * 
             * 
             * Durchschnittsalter von allen Personen mit Schulden ( .Avarage)
             * Alle Personen über 60 mit positivem Kontostand in einem Array
             * Alle Personen mit einem Nachnamen, der länger als 3 Zeichen lang ist in einer List<Person>, Sortiert nach Kontostand
             * Durschnittskontostand von allen Personen unter 40
             * 
             * 
             * 
             * 
             */ 

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static string Auswahlfunktion(Person x) => x.Vorname;
        //{
        //    return x.Vorname;
        //}

        public int Add(int z1, int z2)
        {
            return z1 + z2;
        }

        public int Add2(int z1, int z2) => z1 + z2;

        private int myVar;

        public int MyProperty
        {
            get => myVar;
            set => myVar = value;
        }
        // Macht das Selbe wie:
        //{
        //    get { return myVar; }
        //    set { myVar = value;} 
        //}
}
}
