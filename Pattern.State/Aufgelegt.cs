namespace Pattern.State;

public class Aufgelegt : Telefonzustand
{
    public override Telefonzustand Abheben()
    {
        Console.WriteLine("Erfoglreich abgehoben.");
        return new Abgehoben();
    }
    
    public override Telefonzustand AnrufAnnehmen()
    {
        Console.WriteLine("Anruf erfolgreich angenommen.");
        return new Verbunden();
    }
}