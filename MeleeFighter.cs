public class MeleeFighter : Enemy
{
    //Constructors --------------
    public MeleeFighter(string name) : base(name)
    {
        _EnemyHealth = 120;
        meleeFighterAttackList = new List<Attack>();
    }

    //Method to add an attack

    public void AddToMeleeFighterAttackList(Attack newAttack)
    {
        meleeFighterAttackList.Add(newAttack);
    }


    //Method for random MeleeFighter attack
        public void MeleeFighterRandomAttack(Enemy target)
    {
        Random random = new Random();
        int randomAttackIndex = random.Next(0, meleeFighterAttackList.Count);
        Attack randomAttack = meleeFighterAttackList[randomAttackIndex];

        Console.WriteLine($"{NameOfEnemy} (MeleeFighter) attacked with {randomAttack.NameOfAttack} ");
    }
    //TODO: Add a way to do bonus damage 
    //Rage Method - random attack from its attack list, but +10 dmg...
        public void Rage(Enemy target)
    {
        Random random = new Random();
        int randomAttackIndex = random.Next(0, meleeFighterAttackList.Count);
        Attack randomAttack = meleeFighterAttackList[randomAttackIndex];
        //+10 damage to 
        int rageBuff = randomAttack.DamageAmount +10;

        Console.WriteLine($"{NameOfEnemy} (MeleeFighter) attacked with {randomAttack.NameOfAttack} ");
    }

}