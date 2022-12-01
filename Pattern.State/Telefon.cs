namespace Pattern.State;

public class Telefon
{
    public Telefonzustand AktuellerZustand { get; set; }

    public Telefon()
    {
        AktuellerZustand = new Aufgelegt();
    }

    public void Abheben()
    {
        AktuellerZustand = AktuellerZustand.Abheben();
    }
    
    public void Auflegen()
    {
        AktuellerZustand = AktuellerZustand.Auflegen();
    }
    
    public void Waehlen()
    {
        AktuellerZustand = AktuellerZustand.Waehlen();
    }
    
    public void Sprechen()
    {
        AktuellerZustand = AktuellerZustand.Sprechen();
    }
    
    public void AnrufAnnehmen()
    {
        AktuellerZustand = AktuellerZustand.AnrufAnnehmen();
    }
}