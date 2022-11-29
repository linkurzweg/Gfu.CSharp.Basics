Console.WriteLine("Bitte geben Sie eine Schulnote ein.");

var eingabe =  Console.ReadLine();

try // Laufzeitfehler abfangen
{
    var note = int.Parse(eingabe); // Das kann schiefgehen

    if (note == 1)
        Console.WriteLine("Sehr gut");

    else if (note == 2)
        Console.WriteLine("Gut");
    else if (note == 3)
        Console.WriteLine("Befriedigend");
    else if (note == 4)
        Console.WriteLine("Ausreichend");
    else if (note == 5)
        Console.WriteLine("Mangelhaft");
    else if (note == 6)
        Console.WriteLine("Ungenügend");
    else
        Console.WriteLine("Fehleingabe");

    switch (note) // Mehrwegverzweigung mit switch
    {
        case 1:
            Console.WriteLine("Sehr gut");
            break;
        case 2:
            Console.WriteLine("Gut");
            break;
        case 3:
            Console.WriteLine("Befriedigend");
            break;
        case 4:
            Console.WriteLine("Ausreichend");
            break;
        case 5:
            Console.WriteLine("Mangelhaft");
            break;
        case 6:
            Console.WriteLine("Ungenügend");
            break;
        default:
            Console.WriteLine("Fehleingabe");
            break;
    }
    
    // Variante 3: Mit Array-Variable
    string[] notenbezeichnungen = { "Sehr gut", "Gut", "Befriedigend", "Ausreichend", "Mangelhaft", "Ungenügend" };
    Console.WriteLine(notenbezeichnungen[note - 1]);

}
catch (Exception ex) // Bei einem Fehler springt er hierher
{
    Console.WriteLine("Fehleingabe. Bitte noch einmal probieren."); // Fehlermeldung anzeigen
}