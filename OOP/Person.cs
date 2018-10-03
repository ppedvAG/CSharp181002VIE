using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        #region Gültigkeitsspezifizierer
        //// public       -> Überall sichtbar
        //// private      -> Nur in der eigenen Klasse sichtbar
        //// protected    -> Nur in der eigenen Klasse und allen Klassen, die davon erben, sichtbar

        //// internal     -> Nur in der eigenen Assembly sichtbar
        //// protected interna -> Mischung aus protected und internal

        //// C#7.2:
        //// private protected -> Protected, das nur in der eigenen Assembly gilt, ansonsten private 
        #endregion

        public string vorname;
        public string nachname;
        public byte alter;
        public decimal kontostand;
    }
}
