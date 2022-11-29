namespace Basics10.Parameters;

internal static class Program
{
    private static void Main(string[] args)
    {
        int a = 100, b = 200;
        
        TauscheByValue(a, b);
        Console.WriteLine($"TauscheByValue a:{a}, b:{b}");
        
        TauscheByRef(ref a, ref b);
        Console.WriteLine($"TauscheByRef a:{a}, b:{b}");
    }
    
    /// <summary>
    /// Funktioniert nicht, da x und x Kopien von a und b sind ("call by value") und nur diese Kopien getauscht werden
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>

    private static void TauscheByValue(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    /// <summary>
    /// Kann (wegen ref!) auf die Variablen a und b in Main zugreifen
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    private static void TauscheByRef(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}