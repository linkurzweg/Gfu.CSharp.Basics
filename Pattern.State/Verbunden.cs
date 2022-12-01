namespace Pattern.State;

public class Verbunden : Telefonzustand
{
 public override Telefonzustand Auflegen()
 {
  Console.WriteLine("Erfolgreich aufgelegt.");
  return new Aufgelegt();
 }

 public override Telefonzustand Sprechen()
 {
  Console.WriteLine("Erfolgreich gesprochen.");
  return this;
 }
}