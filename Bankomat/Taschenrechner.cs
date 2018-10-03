using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    // Static class -> Klasse darf nur Member haben, die selbst static sind. Klasse kann (wie abstract) nicht instanziert werden
    static class Taschenrechner
    {
        public static int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Sub(int z1, int z2)
        {
            return z1 - z2;
        }
    }


    partial class Girokonto
    {
        public void Demo1()
        {

        }
        public void Demo2()
        {

        }
    }
}
