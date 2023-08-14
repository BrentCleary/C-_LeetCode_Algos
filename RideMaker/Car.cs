class Car : Ride, INeedFuel
{
  public string FuelType {get; set;}
  public int FuelTotal {get;set;}

  public Car(string fuelType, int fuelTotal) : base("Honda", 4, "Red", true, 50000)
  {
    FuelType = fuelType;
    FuelTotal = fuelTotal;

  }

  public void GiveFuel(int amount)
  {
    System.Console.WriteLine($"{Name} got {amount} of type {FuelType}");
  }
}