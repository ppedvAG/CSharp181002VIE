namespace Rennspiel
{
    interface IMotor
    {
        int MaximalGeschwindigkeit { get; } // Hardcoden in der Klasse
        int Beschleunigen(int aktuelleGeschwindigkeit);
    }


}
