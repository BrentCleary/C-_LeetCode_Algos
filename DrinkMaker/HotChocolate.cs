public class HotChocolate : Drink
{

  public bool AddedMint;

  public HotChocolate(bool mint) : base("Hot Chocolate", "Deep Brown", 100, false, 150)
  {
    AddedMint = mint;
  }

  public override void ShowDrink()
  {
    System.Console.WriteLine(this.Name);
    System.Console.WriteLine(this.Color);
    System.Console.WriteLine(this.Temperature);
    System.Console.WriteLine(this.IsCarbonated);
    System.Console.WriteLine(this.Calories);
    System.Console.WriteLine("----------");
    System.Console.WriteLine(this.AddedMint);
  }
}