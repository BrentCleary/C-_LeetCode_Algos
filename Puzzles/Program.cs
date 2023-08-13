

// Puzzles



// Coin Flip

System.Console.WriteLine("---------------");
System.Console.WriteLine("---Coin Flip---");
System.Console.WriteLine("---------------");

static string CoinFlip(int flipNumber)
{
  Random rand = new Random();
  string result = "";

  int j = 0;
  while( j < flipNumber)
  {
    int returnInt = rand.Next(0,66);

    if(returnInt % 2 == 0)
    {
      result = new string ("heads");
    }
    else
    {
      result = new string ("tails");
    }
    System.Console.WriteLine(result);
    j++;
  }

  return result;
}

System.Console.WriteLine(CoinFlip(5));


// Dice Roll

System.Console.WriteLine("---------------");
System.Console.WriteLine("---Dice Roll---");
System.Console.WriteLine("---------------");

static int DiceRoll(int rollNumbers, int numberOfSides)
{
  Random rand = new Random();
  int result = 0;
  int j = 0;

  while(j < rollNumbers)
  {
    int returnInt = rand.Next(1,numberOfSides+1);
    result = returnInt;
    System.Console.WriteLine(result);
    j++;
  }
  return result;
}

System.Console.WriteLine(DiceRoll(5, 20));