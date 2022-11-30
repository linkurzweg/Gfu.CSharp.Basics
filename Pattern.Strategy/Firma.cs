namespace Pattern.Strategy;

public class Firma
{
    public string Name { get; set; }
    public List<Arbeiter> Mitarbeiter { get; set; } = new ();
    
    public Firma(string wunschname)
    {
        Name = wunschname;
    }

    public void Einstellen(Arbeiter neuerMitarbeiter)
    {
        Mitarbeiter.Add(neuerMitarbeiter);
    }

    public void Produzieren()
    {
        foreach (var arbeiter in Mitarbeiter)
        {
            arbeiter.Arbeiten();
        }
    }
}