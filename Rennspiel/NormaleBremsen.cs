namespace Rennspiel
{
    class NormaleBremsen : IBremse
    {
        public int Bremsen(int aktuelleGeschwindigkeit)
        {

            int BremsKraft = 20;
            if (aktuelleGeschwindigkeit - BremsKraft > 0)
                aktuelleGeschwindigkeit -= 20;
            return aktuelleGeschwindigkeit;
        }
    }




}
