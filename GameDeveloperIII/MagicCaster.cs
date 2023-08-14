public class MagicCaster : Enemy
{

  public MagicCaster(string name) : base("Draggar", 80)
  {
    // MagicCaster Attacks created from Attack class
    Attack Fireball = new Attack("Fireball", 25);
    Attack StaffStrike = new Attack("Staff Strike", 10);
    Attack Bolt = new Attack("Bolt", 20);
    AttackList = new List<Attack>() { Fireball, StaffStrike, Bolt };
    
  }

  // override allows child classes to inherit virtual parent classes and add to them
  public override Attack RandomAttack()
  {
    return base.RandomAttack();
  }

  public void Heal(Enemy Target)
  {
    Target.LifeCheck(Target);
    System.Console.WriteLine("-----------------");

    System.Console.WriteLine($"{this.Name} casts Heal on {Target.Name}");
    Target.ModifyHealth();
  }

}