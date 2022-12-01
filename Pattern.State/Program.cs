using Pattern.State;

var telefon = new Telefon();

telefon.Abheben();
telefon.Waehlen();
telefon.Sprechen();
telefon.Auflegen();

telefon.AnrufAnnehmen();
telefon.Sprechen();
telefon.Auflegen();