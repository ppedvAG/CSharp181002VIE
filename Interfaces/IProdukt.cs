using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IProdukt
    {
        // Definition für alles, was öffentlich ist

        string Name { get; set; }
        decimal Preis { get; set; }


        // Beispiel für eine Methode:
        //void Demo();
    }
}
