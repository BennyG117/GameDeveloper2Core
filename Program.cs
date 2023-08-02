Attack Bolt = new Attack("Lightning Bolt", 15);
Attack Fatal = new Attack("Fatal Push", 10);
Attack GFTT = new Attack("Go for the throat", 25);
Attack Shock = new Attack("Shock", 5);

List<Attack> EnemyAttackList = new List<Attack>
{
    Bolt,
    Fatal,
    GFTT,
    Shock
};

Enemy Goblin = new Enemy("Goblin Engineer");
Enemy Elf = new Enemy("Llanowar Elf");

        // Elf.EnemyAttackList.Add(Bolt);
        Elf.AddToAttackList(Fatal);
        Elf.AddToAttackList(Bolt);
        Elf.AddToAttackList(GFTT);

        Goblin.AddToAttackList(Bolt);
        Goblin.AddToAttackList(Shock);


//         Elf.RandomAttack();
//         Elf.RandomAttack();
//         Elf.RandomAttack();
//         Elf.RandomAttack();

// Console.WriteLine($"{Elf.EnemyHealth}");
// Console.WriteLine("===================");
        
        
//         Goblin.RandomAttack();
//         Goblin.RandomAttack();
// Console.WriteLine("===================");

//==================================================
//! TEST -  MeleeFighter Here
//==================================================
MeleeFighter meleeFighter = new MeleeFighter("Witcher");
// meleeFighter.Rage(Goblin);

// meleeFighter.PerformAttack(Goblin, meleeFighter.EnemyAttackList[2]);


Console.WriteLine("===================");
Console.WriteLine("===================");
//==================================================
//! TEST -  MagicCaster Here
//==================================================
MagicCaster magicCaster = new MagicCaster("Saruman");

// magicCaster.Heal(Goblin);
// magicCaster.PerformAttack(meleeFighter, magicCaster.EnemyAttackList[0]);

Console.WriteLine("===================");
Console.WriteLine("===================");
//==================================================
//! TEST -  RangedFighter Here
//==================================================
RangedFighter rangedFighter = new RangedFighter("Katniss Everdeen");

// rangedFighter.Distance(magicCaster);
// rangedFighter.Dash();
// rangedFighter.PerformAttack(magicCaster, rangedFighter.EnemyAttackList[0]);

Console.WriteLine("==========================================");
Console.WriteLine("=========FIGHT FOR GOTHOM BEGINS==========");
Console.WriteLine("==========================================");

meleeFighter.PerformAttack(rangedFighter, meleeFighter.EnemyAttackList[1]);
Console.WriteLine(">");
meleeFighter.Rage(magicCaster);
Console.WriteLine(">");
rangedFighter.PerformAttack(meleeFighter, rangedFighter.EnemyAttackList[0]);
Console.WriteLine(">");
rangedFighter.Dash();
Console.WriteLine(">");
rangedFighter.PerformAttack(meleeFighter, rangedFighter.EnemyAttackList[0]);
Console.WriteLine(">");
magicCaster.PerformAttack(meleeFighter, magicCaster.EnemyAttackList[0]);
Console.WriteLine(">");
magicCaster.Heal(rangedFighter);
Console.WriteLine(">");
magicCaster.Heal(magicCaster);

