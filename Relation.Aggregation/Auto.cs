namespace Relation.Aggregation;

public class Auto
{
    public string Farbe { get; set; }
    public string Marke { get; }
    public int Tachostand { get; set; }
    public int Tankinhalt { get; set; }
    
    public Motor Motor { get; }
    
    public Rad[] Raeder { get; }

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
        Motor = new Motor();
        Raeder = new Rad[] {new Rad(), new Rad(), new Rad(), new Rad()};
    }

    public void Tanken(int liter)
    {
        Tankinhalt += liter;
    }

    public void Fahren(int kilometer)
    {
        Motor.Anlassen();
        
        Tachostand += kilometer;
        Tankinhalt -= kilometer / 10;
        
        Motor.Abstellen();
    }

    public void Anzeigen()
    {
        Console.WriteLine($"Marke: {Marke}");
        Console.WriteLine($"Farbe: {Farbe}");
        Console.WriteLine($"Tachostand: {Tachostand}");
        Console.WriteLine($"Tankinhalt: {Tankinhalt}");
        
        Motor.Anzeigen();

        foreach (var rad in Raeder)
        {
            rad.Anzeigen();
        }
    }
}