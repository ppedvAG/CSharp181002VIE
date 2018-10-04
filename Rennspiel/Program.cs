using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Rennspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe:
            /* 
             * 3 Motorklassen,(x)
             * "LangsamerMotor", "NormalerMotor", "SchnellerMotor"
             * 
             * 3 Bremsklassen (x)
             * "AbgenutzteBremsen", "NormaleBremsen", "NeueBremsen"
             * 
             * 3 AudioSystemKlassen (x)
             * "Kasettenrekorder", "CD-Player", "MP3-Player"
             * 
             * Programmlogik: (x)
             * 1 Fahrzeug erstellen
             * jede Logik 2-3 mal aufrufen und die Werte in der Konsole ausgeben
             * 
             * 
             * 
             */


            Fahrzeug f = new Fahrzeug(new SchnellerMotor(),new NormaleBremsen(), new MP3Player());

            Console.WriteLine($"aktuelle Geschwindigkeit: {f.Geschwindigkeit}");
            f.Beschleunigen();
            Console.WriteLine($"aktuelle Geschwindigkeit: {f.Geschwindigkeit}");
            f.Beschleunigen();
            Console.WriteLine($"aktuelle Geschwindigkeit: {f.Geschwindigkeit}");
            f.Beschleunigen();
            Console.WriteLine($"aktuelle Geschwindigkeit: {f.Geschwindigkeit}");
            f.Bremsen();
            f.Bremsen();
            f.Bremsen();
            Console.WriteLine($"aktuelle Geschwindigkeit: {f.Geschwindigkeit}");
            f.Beschleunigen();
            Console.WriteLine($"aktuelle Geschwindigkeit: {f.Geschwindigkeit}");
            f.Bremsen();
            Console.WriteLine("Musik abspielen:");
            f.MusikAbspielen();

            Console.WriteLine("---- Ende ----");
            Console.ReadKey();
        }
    }


}
