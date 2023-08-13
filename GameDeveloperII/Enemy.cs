public class Enemy
{
  // -------- Fields ---------
  public string Name;
  private int Health;
  public int _Health
  {
    get{return Health;}
  }
  public List<Attack> AttackList = new List<Attack>();

  // ---------- Constructor ------------
  public Enemy(string name, int health)
  {

    Name = name;
    Health = 100;
    // This initializes and empty Attack List
    AttackList = new List<Attack>();
  }

  // Initialize Attack List
  // This occurs on creation of the new Inherited class
  public void SetAttackList(List<Attack> AttackOptions)
  {
    foreach(Attack attack in AttackOptions)
    {
      this.AttackList.Add(attack);
    }
  }

  // ---------Class Methods --------
  // virtual signals that this method can be overridden by a child method
  public virtual Attack RandomAttack()
  {
    // Initialize Random Method
    Random rand = new Random();
    // Get random index based on AttackList Length
    int index = rand.Next(0, this.AttackList.Count);
    // Create variable storing the random attack from the index
    Attack randomAttack = AttackList[index];
    // Write to console to see it works
    System.Console.WriteLine($"{this.Name} attacks randomly with " + randomAttack.Name);
    // Return it as the result of the function
    return randomAttack;
  }
}