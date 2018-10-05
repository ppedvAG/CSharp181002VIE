using MeineErsteDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleDieEineDLLVerwendet
{
    class Program
    {
        static void Main(string[] args)
        {
            Taschenrechner.Add(12, 1);


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
