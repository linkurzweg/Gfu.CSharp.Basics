var zufallszahlenGenerator = new Random();
var weitererVersuch = "J";

do
{
    // Variablen definieren
    var anzahlVersuche = 0;
    var geheimzahl = zufallszahlenGenerator.Next(1, 101);
    int tipp;

    do
    {
        Console.WriteLine($"Geheimzahl: {geheimzahl}");
        Console.WriteLine();
        
        Console.Write("Tipp eingeben: ");
        var eingabe = Console.ReadLine();
        tipp = int.Parse(eingabe);
        
        anzahlVersuche++;

        if (tipp > geheimzahl)
        {
            Console.WriteLine("leider zu groß..");
        } else if (tipp < geheimzahl)
        {
            Console.WriteLine("leider zu klein...");
        }
    } while(tipp != geheimzahl);
    
    Console.WriteLine($"Richtig! Un das mit nur {anzahlVersuche} Versuchen!");
    Console.Write("Noch einmal versuchen (J/N)? ");
    weitererVersuch = Console.ReadLine();
    Console.Clear();
} while (weitererVersuch == "J" || weitererVersuch == "j");



