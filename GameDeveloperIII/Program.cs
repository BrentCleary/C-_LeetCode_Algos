// Initiate Game
GameRoutine();

// Fight Encounter until someone hits 0 health
void GameRoutine()
{
  // Start of Game - Welcome and Player Creation

  // Create Player and give them a name
  System.Console.WriteLine("Welcome to GDIII! Please enter a name for you Character");
  string playerName = Console.ReadLine();
  System.Console.WriteLine($"Welcome {playerName}");

  // Instantiate Player
  Player newPlayer = new Player(playerName, 100);
  System.Console.WriteLine($"New Player {playerName} has been created!");


  // First Encounter - Random Enemy from enemy List

  // Instantiate Enemies
  MagicCaster magicCaster = new MagicCaster("Maggie");
  Melee meleeFighter = new Melee("Fighto");
  Ranged firstRange = new Ranged("Shooter");

  // Place Enemies in a List
  List<Enemy> enemyList = new List<Enemy>() {magicCaster, meleeFighter, firstRange};
  // Store Random Method
  Random rand = new Random();
  // Set first enemy to a random enemy from the list
  Enemy firstEncounter = enemyList[rand.Next(0, enemyList.Count)];

  System.Console.WriteLine($"A {firstEncounter.Name} approaches!");

  while(newPlayer._Health > 0 || firstEncounter._Health > 0)
  {
    // First Player Attack
    newPlayer.PlayerAttackChoice(firstEncounter);
    // Enemy Attack
    firstEncounter.PerformAttack(newPlayer, firstEncounter.RandomAttack());
    if(newPlayer._Health <= 0)
    {
      System.Console.WriteLine($"You have been defeated by {firstEncounter} {firstEncounter.Name}.");
      RestartGame();
    }
    else if(firstEncounter._Health <= 0)
    {
      System.Console.WriteLine($"You are victorious! Congratulations {newPlayer.Name}!");
      RestartGame();
    }
  }
}

void RestartGame()
{
  bool isValidChoice = false;
  
  while(isValidChoice == false)
  {
    System.Console.WriteLine("Would you like to play again? Y / N");
    string choice = System.Console.ReadLine();

    if(choice == "Y")
    {
      isValidChoice = true;
      GameRoutine();
    }
    else if(choice == "N")
    {
      isValidChoice = true;
      System.Console.WriteLine("Thanks for Playing!");
      break;
    }
    else
    {
      System.Console.WriteLine("Please pick a valid option.");
    }
  }
}


