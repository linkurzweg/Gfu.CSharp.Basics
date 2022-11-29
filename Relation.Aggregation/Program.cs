using Relation.Aggregation;

var meinAuto = new Auto();
meinAuto.Tanken(20);
meinAuto.Fahren(100);

Console.WriteLine(meinAuto.Tachostand);

var deinAuto = new Auto("Mercedes", "Grün");

var seinAuto = new Auto("Porsche");