namespace Relation.Aggregation;

public class Auto
{
    public string Farbe { get; set; }
    public string Marke { get; }
    public int Tachostand { get; set; }
    public int Tankinhalt { get; set; }

    public Auto()
    :this("VW", "blau")
    {
        
    }
    
    public Auto(string wunschmarke)
    :this(wunschmarke, "blau")
    {
        Marke = wunschmarke;
    }
    
    public Auto(string wunschmarke, string wunschfarbe)
    {
        Farbe = wunschfarbe;
        Marke = wunschmarke;
        Tachostand = 0;
        Tankinhalt = 10;
    }

    public void Tanken(int liter)
    {
        Tankinhalt += liter;
    }

    public void Fahren(int kilometer)
    {
        Tachostand += kilometer;
        Tankinhalt -= kilometer / 10;
    }
}