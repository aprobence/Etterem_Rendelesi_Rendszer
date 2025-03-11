namespace Etterem_Rendelesi_Rendszer;

internal class Etel
{
    public string Nev { get; set; }
    public string Kategoria { get; set; }
    public int Ar { get; set; }

    public Etel(string nev, string kategoria, int ar)
    {
        Nev = nev;
        Kategoria = kategoria;
        Ar = ar;
    }
}