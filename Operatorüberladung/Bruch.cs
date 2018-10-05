using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorüberladung
{
    class Bruch
    {
        public Bruch(int Zähler, int Nenner)
        {
            this.Zähler = Zähler;
            this.Nenner = Nenner;
        }

        public int Zähler { get; set; }
        public int Nenner { get; set; }



        /* Operatoren, die man überladen kann:
         * 
         *  Arithmetische Operatoren
         *  +,-,*,/,++,--,%
         *  Bitweise Operatoren
         *  &,|,^, << , >>
         *  Vergleichsoperatoren
         *  <,>,<=,>=, ==, !=
         *     => Achtung: paarweise Überladen (wenn <, muss auch das > überladen werden)
         */ 

        // Bruch erg = b1 * b2;
        public static Bruch operator *(Bruch left,Bruch right)
        {
            return new Bruch(left.Zähler * right.Zähler, left.Nenner * right.Nenner);
        }
    }
}
