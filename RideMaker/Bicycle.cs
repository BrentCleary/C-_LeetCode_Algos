class Bicycle : Ride
{
  public string FuelType {get;set;}
  public int FuelTotal {get;set;}

  public Bicycle(string fuelType, int fuelTotal) : base("TownBike", 2, "Blue", false, 500)
  {
    FuelType = "Legs";
    FuelTotal = 10;
  }

  public void GiveFuel(int amount)
  {
    System.Console.WriteLine($"{Name} got {amount} of type {FuelType}");
  }

}