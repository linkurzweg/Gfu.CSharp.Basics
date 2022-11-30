namespace Pattern.Strategy;

public class Maler : Arbeiter
{
    public Maler(string wunschname) : base(wunschname)
    {
    }

    public override void Arbeiten()
    {
        Console.WriteLine($"Der Maler {Name} streicht eine Wand.");
    }
}