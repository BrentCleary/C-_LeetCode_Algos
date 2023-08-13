class Enemy
{
  public string Name;
  private int Health;
  public int _Health
  {
    get{return Health;}
  }
  public List<Attack> AttackList = new List<Attack>();

  public Enemy(string name, int health, List<Attack> attackList)
  {

    Name = name;
    Health = 100;
    AttackList = attackList;
  }

  public Attack RandomAttack()
  {
    // Initialize Random Method
    Random rand = new Random();

    // Get random index based on AttackList Length
    int index = rand.Next(0, this.AttackList.Count);

    // Create variable storing the random attack from the index
    Attack randomAttack = AttackList[index];

    // Write to console to see it works
    System.Console.WriteLine(randomAttack.Name);

    // Return it as the result of the function
    return randomAttack;
  }
}