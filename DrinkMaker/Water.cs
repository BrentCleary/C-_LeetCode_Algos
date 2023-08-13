public class Water : Drink
{

  public bool Chilled;

  public Water(bool chilled) : base("Water", "clear", 50, false, 0)
  {
    Chilled = chilled;
  }

  public override void ShowDrink()
  {
    System.Console.WriteLine(this.Name);
    System.Console.WriteLine(this.Color);
    System.Console.WriteLine(this.Temperature);
    System.Console.WriteLine(this.IsCarbonated);
    System.Console.WriteLine(this.Calories);
    System.Console.WriteLine("----------");
    System.Console.WriteLine(this.Chilled);
  }
}