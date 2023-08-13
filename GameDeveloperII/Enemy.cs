public class Enemy
{
  // -------- Fields ---------
  public string Name;
  protected int Health;
  public int _Health
  {
    get{return Health;}
  }
  private int maxHealth;
  public List<Attack> AttackList = new List<Attack>();

  // ---------- Constructor ------------
  public Enemy(string name, int health)
  {

    Name = name;
    Health = 100;
    maxHealth = Health;
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
    System.Console.WriteLine("-----------------");

    // Initialize Random Method
    Random rand = new Random();
    // Get random index based on AttackList Length
    int index = rand.Next(0, this.AttackList.Count);
    // Create variable storing the random attack from the index
    Attack randomAttack = AttackList[index];
    // Return it as the result of the function
    return randomAttack;
  }

  public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    LifeCheck(Target);
    System.Console.WriteLine("-----------------");

    if(Target._Health >= 0)
    {
      int AttackIndex = this.AttackList.IndexOf(ChosenAttack);
      Attack thisAttack = AttackList[AttackIndex];
      Target.Health -= thisAttack.DamageAmount;

      // Write some logic here to reduce the Targets health by your Attack's DamageAmount
      Console.WriteLine($"{Name} attacks {Target.Name} with {thisAttack.Name}, dealing {thisAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }
  }

  public void ModifyHealth()
  {
    
    System.Console.WriteLine("-----------------");
    int currentHealth = this._Health;
    int healFactor = 40;
    // maxHealth Check
    if(currentHealth + healFactor > maxHealth)
    {
      this.Health = maxHealth;
      System.Console.WriteLine($"{this.Name} was healed to full {this.maxHealth} health.");
    }
    else
    {
      Health += healFactor;
      System.Console.WriteLine($"{this.Name}'s health was {currentHealth}, and was healed for {healFactor}. Health is now {this._Health}");
    }
  }

  public void LifeCheck(Enemy Target)
  {
    if(Target._Health <= 0)
    {
      System.Console.WriteLine($"{Target.Name} has already fainted.");
      return;
    }
  }

}