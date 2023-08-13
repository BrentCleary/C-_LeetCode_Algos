

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



// Dice Roll List

System.Console.WriteLine("---------------");
System.Console.WriteLine("---Dice Roll List---");
System.Console.WriteLine("---------------");


static int DiceRollList(int rollNumbers, int numberOfSides)
{
  Random rand = new Random();
  List<int> diceRolls = new List<int>();
  int result = 0;
  int j = 0;
  int highestRoll = 0;

  while(j < rollNumbers)
  {
    int returnInt = rand.Next(1,numberOfSides+1);
    result = returnInt;
    diceRolls.Add(result);
    System.Console.WriteLine(result);
    j++;
  }
  
  foreach(int val in diceRolls)
  {
    if(val >= highestRoll)
    {
      highestRoll = val;
    }
    System.Console.WriteLine("Value is " + val);
  }

  System.Console.WriteLine("Highest Roll is " + highestRoll);
  return result;
}

System.Console.WriteLine(DiceRollList(5, 20));


// Dice Roll Tracker

System.Console.WriteLine("---------------");
System.Console.WriteLine("---Dice Roll List---");
System.Console.WriteLine("---------------");


static int DiceRollSearch(int rollNumbers, int numberOfSides)
{
  // Random Function
  Random rand = new Random();
  
  // Number to stop the loop on
  int rollTarget = rand.Next(1,numberOfSides);
  System.Console.WriteLine("Target Roll is " + rollTarget);
  
  List<int> diceRolls = new List<int>();
  int numberOfRolls = 0;
  int highestRoll = 0;

  int result = 0;
  int j = 0;

  while(result != rollTarget)
  {
    numberOfRolls += 1;
    int returnInt = rand.Next(1, numberOfSides+1);
    result = returnInt;
    diceRolls.Add(result);
    System.Console.WriteLine("Roll number " + numberOfRolls + " is " + result);
    j++;
  }


  System.Console.WriteLine("Dice matched " + rollTarget + " on roll number " + numberOfRolls + ".");
  return result;
}

System.Console.WriteLine(DiceRollSearch(5, 8));