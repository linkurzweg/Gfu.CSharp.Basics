namespace Pattern.State;

public class Abgehoben : Telefonzustand
{
    public override Telefonzustand Auflegen()
    {
        Console.WriteLine("Erfolgreich aufgelegt.");
        return new Aufgelegt();
    }

    public override Telefonzustand Waehlen()
    {
        Console.WriteLine("Erfolgreich gewählt.");
        return new Verbunden();
    }
}