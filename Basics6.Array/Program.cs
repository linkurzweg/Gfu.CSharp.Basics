double[] umsatzzahlen = new double[4];

// 4 Quartalsumsätze eingeben
for (int quartal = 0; quartal < umsatzzahlen.Length; quartal++)
{
    // Umsatz eingeben
    Console.WriteLine("Umsatz eingeben:");
    var eingabe = Console.ReadLine();
    umsatzzahlen[quartal] = double.Parse(eingabe);
}

// Quartalsumsätze rückwärts wieder ausgeben
for (int quartal = umsatzzahlen.Length - 1; quartal >= 0; quartal--)
{
    Console.WriteLine($"Umsatz Quartal {quartal+1} {umsatzzahlen[quartal]:C2}");
}