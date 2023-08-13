using System.Collections.Concurrent;

class Ranged : Enemy
{
  int distance = 5;

  public Ranged(string name) : base(name, 100)
  {
    Attack ShootArrow = new Attack("Arrow Shot", 20);
    Attack KnifeThrow = new Attack("Knife Throw", 15);
    AttackList = new List<Attack>() { ShootArrow, KnifeThrow };
  }

  // Conditional Ranged Attack
  public override void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    if(distance < 10)
    {
      System.Console.WriteLine("-----------------");

      System.Console.WriteLine("Ranged fighter is out of range! Need to move away!");
    }
    else
    {
      base.PerformAttack(Target, ChosenAttack);
    }
  }

  // Dash Attack to get out of distance
  public void Dash()
  {
    System.Console.WriteLine("-----------------");
    
    System.Console.WriteLine($"{this.Name} is at {distance} from the target!");
    distance = 20;
    System.Console.WriteLine($"{this.Name} dashes and is now {distance} from the target!");
  }

}