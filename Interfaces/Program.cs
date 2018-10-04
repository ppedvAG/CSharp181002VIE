using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Händler Max = new Händler();
            Max.Anzahl = 500;
            Max.Produkt = new Obst("Brasilien", "Banane", 120, 3.99m);

            // Objektinitialisierer
            Händler Moritz = new Händler()
            {
                Anzahl = 1000,
                Produkt = new Gemüse() { Bitter=false,Name="Erdäpfel",Preis=0.99m}
            };

            Händler Martha = new Händler()
            {
                Anzahl = 12,
                Produkt = new Obst("Burgenland", "Weintrauben", 50, 15.99m)
            };

            // if(Martha.Produkt is Obst)
                

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
