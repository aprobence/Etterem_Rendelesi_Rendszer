namespace Etterem_Rendelesi_Rendszer;

internal class Rendeles
{
    public Felhasznalo Megrendelo { get; set; }
    public List<Etel> Termekek { get; set; }
    public string Allapot { get; set; }

    public Rendeles(Felhasznalo megrendelo, List<Etel> termekek)
    {
        Megrendelo = megrendelo;
        Termekek = termekek;
        Allapot = "Feldolgozás alatt";
    }

    public void AllapotFrissit(string ujAllapot)
    {
        Allapot = ujAllapot;
        Console.WriteLine($"A rendelés állapota frissítve: {ujAllapot}");
    }

    public override string ToString()
    {
        return $"Megrendeló: {Megrendelo.Nev}, Állapot: {Allapot}, Termékek: {string.Join(", ", Termekek.Select(t => t.Nev))}";
    }
}