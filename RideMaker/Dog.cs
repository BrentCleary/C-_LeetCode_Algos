class Dog
{
  private string Name;
  // public setting string for name
  public string _Name
  {
    get
    {
      return Name;
    }
    set
    {
      Name = value;
    }
  }
  public string Breed;
  public string FurColor {get; set;}

  public Dog(string n, string b, string f)
  {
    Name = n;
    Breed = b;
    FurColor = f;
  }

  void Bark()
  {
    System.Console.WriteLine("Bark Bark!");
  }

  void Fetch()
  {
    System.Console.WriteLine($"{Name} hurries to fetch the ball!");
  }

}

