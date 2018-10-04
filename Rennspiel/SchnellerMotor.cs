using System;

namespace Rennspiel
{
    class SchnellerMotor : IMotor
    {
        public int MaximalGeschwindigkeit => 300;
        public int Beschleunigen(int aktuelleGeschwindigkeit)
        {
            if (aktuelleGeschwindigkeit + 15 <= MaximalGeschwindigkeit)
            {
                aktuelleGeschwindigkeit += 15;
            }
            else
            {
                Console.WriteLine("Nicht Möglich");
            }
            return aktuelleGeschwindigkeit;
        }
    }


}
