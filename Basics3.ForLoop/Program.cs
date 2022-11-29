// Jahresumsatz berechnen aus Monatsumsätzen

decimal jahresumsatz = 0; // Decimal für Geldbeträge

// Initialisierung; Laufbedingung; Reinitialisierung 
for (var monat = 1; monat < 12; monat++) // Zählergesteuerte Schleife
{
    // Umsatz eingeben
    Console.Write("Monatsumsatz eingeben: ");
    var eingabe = Console.ReadLine();
    
    // Eingabe in Zahl umwandeln
    var monatsumsatz = decimal.Parse(eingabe);

    // Jahresumsatz berechnen
    jahresumsatz += monatsumsatz;
}

// Jahresumsatz anzeigen
Console.WriteLine($"Der Jahresumsatz beträgt {jahresumsatz:C2}" );