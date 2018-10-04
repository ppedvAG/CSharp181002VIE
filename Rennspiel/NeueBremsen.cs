namespace Rennspiel
{
    class NeueBremsen : IBremse
    {
        public int Bremsen(int aktuelleGeschwindigkeit)
        {
            int BremsKraft = 30;
            if (aktuelleGeschwindigkeit - BremsKraft > 0)
                aktuelleGeschwindigkeit -= BremsKraft;



            return aktuelleGeschwindigkeit;
        }
    }




}
