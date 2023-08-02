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
//! Starting MeleeFighter Here
//==================================================
MeleeFighter meleeFighter = new MeleeFighter("Witcher");
meleeFighter.Rage(Goblin);

meleeFighter.PerformAttack(Goblin, meleeFighter.EnemyAttackList[2]);