public class Melee : Enemy
{

  public Melee(string name) : base("Fighto", 120)
  {
    // Melee Class initialize attacks
    Attack Punch = new Attack("Punch", 20);
    Attack Kick = new Attack("Kick", 15); 
    Attack Tackle = new Attack("Tackle", 25); 
    AttackList = new List<Attack>() { Punch, Kick, Tackle };
  }

  public void Rage(Enemy Target)
  {
    LifeCheck(Target);
    System.Console.WriteLine("-----------------");

    // Call on the RandomAttack Function
    Attack RageAttack = RandomAttack();
    RageAttack.DamageAmount += 10;

    System.Console.WriteLine($"{this.Name} goes into a Rage!");
    PerformAttack(Target, RageAttack);
    System.Console.WriteLine($"{this.Name} performs {RageAttack.Name} and reduces {Target.Name}'s health by {RageAttack.DamageAmount}! {Target.Name}'s Health is {Target._Health}.");

  }

}