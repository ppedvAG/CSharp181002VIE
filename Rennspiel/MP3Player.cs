using System;

namespace Rennspiel
{
    class MP3Player : IAudioSystem
    {
        public void MusikAbspielen()
        {
            Console.WriteLine("Ich spiele gerade über deinen MP3 Player: Umtataaaaah Umtataah");
        }
    }
}
