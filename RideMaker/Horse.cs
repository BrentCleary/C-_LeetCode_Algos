class Horse : Ride, INeedFuel
{
  public string FuelType {get;set;}
  public int FuelTotal {get;set;}

  public Horse(string fuelType, int fuelTotal) : base("Mr. Ed", 1, "Brown", false, 1000)
  {
    FuelType = fuelType;
    FuelTotal = fuelTotal;
  }

  public void GiveFuel(int amount)
  {
    System.Console.WriteLine($"{Name} got {amount} of type {FuelType}");
  }

}