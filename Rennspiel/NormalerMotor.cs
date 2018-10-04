using System;

namespace Rennspiel
{
    class NormalerMotor : IMotor
    {
        public int MaximalGeschwindigkeit => 250;
        public int Beschleunigen(int aktuelleGeschwindigkeit)
        {
            if (aktuelleGeschwindigkeit + 10 <= MaximalGeschwindigkeit)
            {
                aktuelleGeschwindigkeit += 10;
            }
            else
            {
                Console.WriteLine("Nicht Möglich");
            }
            return aktuelleGeschwindigkeit;
        }
    }


}
