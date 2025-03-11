namespace Etterem_Rendelesi_Rendszer;

internal class Etterem
{
    public List<Etel> Etelek { get; set; }
    public List<Rendeles> Rendelesek { get; set; }
    
    public Etterem()
    {
        Etelek = new List<Etel>();
        Rendelesek = new List<Rendeles>();
    }
    
    public void BeolvasEtelek(string fajlnev)
    {
        if (!File.Exists(fajlnev))
        {
            Console.WriteLine($"A fájl nem található: {fajlnev}");
            return;
        }

        foreach (var sor in File.ReadAllLines(fajlnev))
        {
            var adatok = sor.Split(',');
            if(adatok.Length == 3 && int.TryParse(adatok[2], out int ar))
            {
                Etelek.Add(new Etel(adatok[0], adatok[1], ar));
            }
        }
        Console.WriteLine($"{Etelek.Count} db étel beolvasva.");
    }

    public void UjRendeles(Rendeles rendeles)
    {
        Rendelesek.Add(rendeles);
    }
}