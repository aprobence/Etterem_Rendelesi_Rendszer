namespace Etterem_Rendelesi_Rendszer;

internal class Felhasznalo
{
    public string Nev { get; set; }
    public List<Etel> Kosar { get; set; }
    
    public Felhasznalo(string nev)
    {
        Nev = nev;
        Kosar = new List<Etel>();
    }
    
    public void KosarbaTesz(Etel etel)
    {
        Kosar.Add(etel);
        Console.WriteLine("Az étel a kosárba került.");
    }
    
    public void KosarMegtekint()
    {
        Console.WriteLine($"{Nev} kosara:");
        if (Kosar.Count == 0)
        {
            Console.WriteLine("A kosár üres.");
        }
        foreach (var etel in Kosar)
        {
            Console.WriteLine(etel.Nev);
        }
    }

   public Rendeles Rendel()
   {
       if (Kosar.Count == 0)
       {
           Console.WriteLine("A kosár üres, nem lehet rendelést leadni.");
           return null;
       }
       
       var rendeles = new Rendeles(this, new List<Etel>(Kosar));
       Kosar.Clear();
       return rendeles;
   }
}