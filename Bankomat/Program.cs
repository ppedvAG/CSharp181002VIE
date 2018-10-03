using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto();
            Jugendkonto j1 = new Jugendkonto();
            Konto k2 = new Jugendkonto();

            Taschenrechner tr = new Taschenrechner();
            int erg = tr.Add(12, 5);

            Taschenrechner.demo = 5;

            Girokonto gk = new Girokonto();

            gk.


            Console.WriteLine("Hallo Welt");
            Convert.ToInt32("123");



            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
