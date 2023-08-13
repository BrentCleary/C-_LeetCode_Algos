// Bandit Attacks

Attack Fireball = new Attack("Fireball", 100);
Attack Punch = new Attack("Punch", 50);
Attack Wind = new Attack("Wind", 25);

List<Attack> BanditAttacks = new List<Attack>() {Fireball, Punch, Wind};
// BanditAttacks.Add(Fireball);
// BanditAttacks.Add(Punch);
// BanditAttacks.Add(Wind);

foreach (Attack item in BanditAttacks)
{
  System.Console.WriteLine(item.Name);
}

Enemy Bandit = new Enemy("Bandit", 100, BanditAttacks);

Bandit.RandomAttack();
