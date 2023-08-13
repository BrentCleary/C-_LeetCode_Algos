public class Bandit : Enemy
{

  public Bandit(string name) : base("Draggar", 100)
  {
    // Bandit Attacks created from Attack class
    Attack Fireball = new Attack("Fireball", 100);
    Attack Punch = new Attack("Punch", 50);
    Attack Wind = new Attack("Wind", 25);
    AttackList = new List<Attack>() { Fireball, Punch, Wind };
    
  }

  // override allows child classes to inheret virtual parent classes and add to them
  public override Attack RandomAttack()
  {
    System.Console.WriteLine("Plus this text");
    System.Console.WriteLine("Plus this text");
    return base.RandomAttack();
  }

}