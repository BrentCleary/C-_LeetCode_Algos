// // MagicCaster Attacks

// Attack Fireball = new Attack("Fireball", 100);
// Attack Punch = new Attack("Punch", 50);
// Attack Wind = new Attack("Wind", 25);

MagicCaster firstMagicCaster = new MagicCaster("Maggie");
Melee meleeFighter = new Melee("Fighto");
Ranged firstRange = new Ranged("Shooter");


firstMagicCaster.PerformAttack(meleeFighter, firstMagicCaster.AttackList[0]);

firstRange.PerformAttack(firstMagicCaster, firstRange.AttackList[0]);
firstRange.Dash();
firstRange.PerformAttack(firstMagicCaster, firstRange.AttackList[0]);


meleeFighter.Rage(firstMagicCaster);
meleeFighter.Rage(firstMagicCaster);
meleeFighter.Rage(firstMagicCaster);
meleeFighter.Rage(firstMagicCaster);

firstMagicCaster.Heal(meleeFighter);
firstMagicCaster.Heal(meleeFighter);
firstMagicCaster.Heal(meleeFighter);
firstMagicCaster.Heal(meleeFighter);

firstMagicCaster.Heal(firstMagicCaster);