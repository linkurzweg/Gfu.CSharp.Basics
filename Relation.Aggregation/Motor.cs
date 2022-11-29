namespace Relation.Aggregation;

public class Motor
{
    public int Drehzahl { get; set; }
    public  int PS { get; set; }

    public Motor()
    {
        Drehzahl = 0;
        PS = 100;   
    }

    public void Anlassen()
    {
        Drehzahl = 1000;
        Console.WriteLine("Motor wurde angelassen.");
    }

    public void Abstellen()
    {
        Drehzahl = 0;
        Console.WriteLine("Motor wurde abgestellt.");
    }


    public void Anzeigen()
    {
        Console.WriteLine($"Drehzahl: {Drehzahl}");
        Console.WriteLine($"PS: {PS}");
    }
}