class Player : Enemy
{
  bool Charged = false;
  
  public Player(string name, int health) : base("You", 200)
  {
    Name = name;

    Attack Sword = new Attack("Sword", 25);
    Attack MagicShot = new Attack("Magic", 15); 
    Attack Counter = new Attack("Counter", 50);
    Attack JumpAttack = new Attack("Charge", 30);
    AttackList = new List<Attack>() {Sword, MagicShot, Counter, JumpAttack};
  }

  public override void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    base.PerformAttack(Target, ChosenAttack);
  }

  public void Charge()
  {
    Charged = true;
  }


  public void PlayerAttackChoice(Enemy Target)
  {
    // Ask Player to input a number
    System.Console.WriteLine($"Type 1 for {AttackList[0].Name}");
    System.Console.WriteLine($"Type 2 for {AttackList[1].Name}");
    System.Console.WriteLine($"Type 3 for {AttackList[2].Name}");
    System.Console.WriteLine($"Type 4 for {AttackList[3].Name}");
    string playerChoice = System.Console.ReadLine();
    
    int attIdx = int.Parse(playerChoice);
    
    PerformAttack(Target, AttackList[attIdx-1]);
  }
}