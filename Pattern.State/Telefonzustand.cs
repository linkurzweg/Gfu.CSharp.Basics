namespace Pattern.State;

public abstract class Telefonzustand
{
    private Telefonzustand NotPossible()
    {
        Console.WriteLine("Geht gerade nicht");
        return this;
    }
    
    public virtual Telefonzustand Abheben()
    {
        return NotPossible();
    }
    
    public virtual Telefonzustand AnrufAnnehmen()
    {
        return NotPossible();
    }
    
    public virtual Telefonzustand Auflegen()
    {
        return NotPossible();
    }
    
    public virtual Telefonzustand Sprechen()
    {
        return NotPossible();
    }
    
    public virtual Telefonzustand Waehlen()
    {
        return NotPossible();
    }
}