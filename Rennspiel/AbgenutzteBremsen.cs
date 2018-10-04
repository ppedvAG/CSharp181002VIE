namespace Rennspiel
{
    class AbgenutzteBremsen : IBremse
    {
        int IBremse.Bremsen(int aktuelleGeschwindigkeit)
        {
            int BremsKraft = 20;
            if (aktuelleGeschwindigkeit - BremsKraft > 0)
                aktuelleGeschwindigkeit -= 10;
            return aktuelleGeschwindigkeit;

        }


    }




}
