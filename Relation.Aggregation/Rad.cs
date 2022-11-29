namespace Relation.Aggregation;

public class Rad
{
    public int Luftdruck { get; set; }

    public Rad()
    {
        Luftdruck = 2;
    }

    public void Anzeigen()
    {
        Console.WriteLine($"luftdruck: {Luftdruck}");
    }
}