using System;

namespace Rennspiel
{
    class LangsamerMotor : IMotor
    {
        public int MaximalGeschwindigkeit => 200;
        public int Beschleunigen(int aktuelleGeschwindigkeit)
        {
            if (aktuelleGeschwindigkeit + 5 <= MaximalGeschwindigkeit)
            {
                aktuelleGeschwindigkeit += 5;
            }
            else
            {
                Console.WriteLine("Nicht Möglich");
            }
            return aktuelleGeschwindigkeit;
        }
    }


}
