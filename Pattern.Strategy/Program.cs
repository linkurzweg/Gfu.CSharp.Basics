using Pattern.Strategy;

var malerFirma = new Firma("Malerfirma Lustig");
var maler1 = new Maler("Meier");
var maler2 = new Maler("Schulz");
malerFirma.Einstellen(maler1);
malerFirma.Einstellen(maler2);
malerFirma.Produzieren();

var schreinerFirma = new Firma("Schreinerei Schulz");
var schreiner = new Schreiner("Müller");
schreinerFirma.Einstellen(schreiner);
schreinerFirma.Produzieren();

var zeitarbeitsFirma = new Firma("Zeitarbeit");
zeitarbeitsFirma.Einstellen(new Maler("Fritz"));
zeitarbeitsFirma.Einstellen(new Schreiner("Alfons"));
zeitarbeitsFirma.Produzieren();