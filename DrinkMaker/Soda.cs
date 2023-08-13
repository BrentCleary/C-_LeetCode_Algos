public class Soda : Drink
{
  public string Flavor;

  public Soda(string flavor) : base("Soda", "brown", 35, true, 120)
  {
    Flavor = flavor;
  }

  public override void ShowDrink()
  {
    System.Console.WriteLine(this.Name);
    System.Console.WriteLine(this.Color);
    System.Console.WriteLine(this.Temperature);
    System.Console.WriteLine(this.IsCarbonated);
    System.Console.WriteLine(this.Calories);
    System.Console.WriteLine("----------");
    System.Console.WriteLine(this.Flavor);
  }

}