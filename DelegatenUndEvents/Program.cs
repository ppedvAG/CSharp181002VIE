using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Program
    {
        // Delegate-Typ
        public delegate void MeinDelegat();
        public delegate int Rechenart(int z1, int z2);
        static void Main(string[] args)
        {
            #region Delegate
            //MeinDelegat del = new MeinDelegat(A);
            //del += B;
            //del.Invoke(); 
            #endregion


            #region Variante ohne delegate
            //Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            //int z1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //int z2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitte geben Sie den Rechenoperator ein");
            //string rechenOperator = Console.ReadLine();

            //int erg = 0;
            //if (rechenOperator == "+")
            //    erg = Add(z1, z2);
            //else if (rechenOperator == "-")
            //    erg = Sub(z1, z2);

            //Console.WriteLine($"Das Ergebnis ist {erg}"); 
            #endregion
            #region Variante mit delegate
            //Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            //int z1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //int z2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitte geben Sie den Rechenoperator ein");
            //string rechenOperator = Console.ReadLine();

            //Rechenart rechnung = null;
            //if (rechenOperator == "+")
            //    rechnung = Add;
            //else if (rechenOperator == "-")
            //    rechnung = Sub;

            //Console.WriteLine($"Das Ergebnis ist {rechnung(z1,z2)}"); 
            #endregion
            #region Action, Func, EventHandler
            //// Action -> alles was void ist
            //Action a = A;
            //Action b = B;
            //Action<int> c = C;

            //// Func -> alles, was ein ergebnis hat
            //// Letzte Angabe des Datentypen: Rückgabe
            //Func<int, string> irgendwas = Machwas;
            //Func<int, int, int> demo = Add;

            //// EventHandler (bei GUI -> WPF oder WinForms)
            //EventHandler meinButtonEvent = ABCDE12345; 
            #endregion


            Button b = new Button();
            b.ButtonClickEvent += MeinKonsolenButtonClick;
            b.ButtonClickEvent += Logger;

            b.Click();

            b.ButtonClickEvent = null;           // absolut verboten

            b.Click();
            b.Click();
            b.ButtonClickEvent -= Logger;

            b.Click();
            b.Click();

            if(b.ButtonClickEvent != null)
                b.ButtonClickEvent.Invoke();         // verboten

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static void Logger()
        {
            Console.WriteLine($"[{DateTime.Now}]: Button wurde geklickt");
        }

        private static void MeinKonsolenButtonClick()
        {
            //Console.Beep();
            Console.WriteLine("*click*");
        }

        private static void ABCDE12345(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public static string Machwas(int zahl)
        {
            return zahl.ToString();
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static void A()
        {
            Console.WriteLine("A");
        }
        public static void B()
        {
            Console.WriteLine("B");
        }
        public static void C(int zahl)
        {
            Console.WriteLine($"C {zahl}");
        }
    }
}
