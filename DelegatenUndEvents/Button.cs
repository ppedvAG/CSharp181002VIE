using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Button
    {
        // Variante "Lang"
        //private Action buttonClick;
        //public event Action ButtonClickEvent
        //{
        //    add
        //    {
        //        buttonClick += value;
        //    }
        //    remove
        //    {
        //        buttonClick -= value;
        //    }
        //}

        // Variante "kurz"
        public event Action ButtonClickEvent;

        public void Click()
        {
            if(ButtonClickEvent != null)
                ButtonClickEvent.Invoke();
        }
    }
}
