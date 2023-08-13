public class Drink
{
  // Class Fields
  public string Name;
  public string Color;
  public double Temperature;
  public bool IsCarbonated;
  public int Calories;

  // Class Constructor
  public Drink(string name, string color, double temperature, bool isCarb, int calories)
  {
    Name = name;
    Color = color;
    Temperature = temperature;
    IsCarbonated = isCarb;
    Calories = calories;
  }


  // Class Methods
  public virtual void ShowDrink()
  {
    System.Console.WriteLine(this.Name);
    System.Console.WriteLine(this.Color);
    System.Console.WriteLine(this.Temperature);
    System.Console.WriteLine(this.IsCarbonated);
    System.Console.WriteLine(this.Calories);
  }


}