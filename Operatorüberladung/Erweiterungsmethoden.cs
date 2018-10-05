using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorüberladung
{
    static class Erweiterungsmethoden
    {
        // Anforderung für Erweiterungsmethoden
        // 1) statische Klasse
        // 2) this - Schlüsselwort

        public static int Verdoppeln(this int input)
        {
            return input * 2;
        }


        public static string Umdrehen(this string input)
        {
            // forr -> Reverse for
            //string umgedreht = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    umgedreht += input[i];
            //}
            //return umgedreht;

            StringBuilder sb = new StringBuilder();     // Optimierte Variante um den Speicherverbrauch beim zusammenhängen von Zeichenketten zu verringern
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();

            // return string.Join(string.Empty,input.Reverse());
        }





    }
}
