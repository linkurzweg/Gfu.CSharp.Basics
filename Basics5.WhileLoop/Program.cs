// Projekt "Kaufrausch"

decimal budget = 0;

// Eingabe: Wieviel Geld nehme ich heute mit?
Console.Write("Wieviel Geld nehme ich heute mit: ");
var eingabeBudget = Console.ReadLine();
budget += decimal.Parse(eingabeBudget);

while (budget > 0)
{
    // Nach Preis fragen
    Console.Write("Wie hoch ist der Preis? ");
    var eingabePreis = Console.ReadLine();

    var preis = decimal.Parse(eingabePreis);

    if (preis == 0)
    {
        break;
    }

    budget -= preis;
}

// Meldung: Kaufrausch beendet, (Rest-)Geld anzeigen
Console.WriteLine($"Kaufrausch beendet. Übriges Geld: {budget}");