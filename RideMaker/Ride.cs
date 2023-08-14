class Ride
{
  public string Name;
  public int Passengers;
  public string Color;
  public bool Engine;
  private int MilesTraveled;

  // First Constructor
  public Ride(string name, int passengers, string color, bool engine, int milesTraveled)
  {
    Name = name;
    Passengers = passengers;
    Color = color;
    Engine = engine;
    MilesTraveled = milesTraveled;
  }

  // Second Constructor
  public Ride(string name, int passengers, string color, bool engine)
  {
    Name = name;
    Passengers = passengers;
    Color = color;
    Engine = engine;
  }

  public void ShowInfo()
  {
    System.Console.WriteLine($"{Name}, {Passengers}, {Color}, {Engine}, {MilesTraveled}");
  }

  public void Travel(int milesToAdd)
  {
    System.Console.WriteLine("Current miles are " + MilesTraveled);
    MilesTraveled = MilesTraveled + milesToAdd;
    System.Console.WriteLine("New miles are " + MilesTraveled);
  }

}

