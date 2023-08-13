// // Bandit Attacks

// Attack Fireball = new Attack("Fireball", 100);
// Attack Punch = new Attack("Punch", 50);
// Attack Wind = new Attack("Wind", 25);

// List<Attack> BanditAttacks = new List<Attack>() {Fireball, Punch, Wind};
// // BanditAttacks.Add(Fireball);
// // BanditAttacks.Add(Punch);
// // BanditAttacks.Add(Wind);

// foreach (Attack item in BanditAttacks)
// {
//   System.Console.WriteLine(item.Name);
// }

Bandit newBandit = new Bandit("Draggar");

System.Console.WriteLine(newBandit.Name);

foreach(Attack att in newBandit.AttackList)
{
  System.Console.WriteLine(att.Name);
}

newBandit.RandomAttack();