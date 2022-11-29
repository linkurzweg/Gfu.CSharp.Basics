double gesamtSumme = 0;
double umsatz = 0;

do
{
    // Umsatz eingeben
    Console.Write("Umsatz eingeben: ");
    var eingabe = Console.ReadLine();

    // Eingabe in Zahl umwandeln
    umsatz = double.Parse(eingabe);
    
    // Umsatz zu Gesamtumsatz addieren
    gesamtSumme += umsatz;

} while (umsatz != 0);

Console.WriteLine($"Der Gesamtumsatz beträgt: {gesamtSumme}");