using Relation.Aggregation;

var meinAuto = new Auto();
meinAuto.Tanken(20);
meinAuto.Fahren(100);

meinAuto.Anzeigen();

Console.WriteLine(meinAuto.Tachostand);

var deinAuto = new Auto("Mercedes", "Grün");
deinAuto.Anzeigen();

deinAuto.Farbe = "Grün";
meinAuto.Tanken(50);
meinAuto.Fahren(500);

var seinAuto = new Auto("Porsche");
seinAuto.Anzeigen();