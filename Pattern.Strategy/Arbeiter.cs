namespace Pattern.Strategy;

public abstract class Arbeiter
{
    public string Name { get; set; }

    public Arbeiter(string wunschname)
    {
        Name = wunschname;
    }

    public abstract void Arbeiten();
}