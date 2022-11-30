namespace Pattern.Strategy;

public class Schreiner : Arbeiter
{
    public Schreiner(string wunschname) : base(wunschname)
    {
    }

    public override void Arbeiten()
    {
        Console.WriteLine($"Der Schreiner {Name} baut einen Schrank.");
    }
}