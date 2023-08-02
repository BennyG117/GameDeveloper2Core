public class MagicCaster : Enemy
{
    //Constructors --------------
    public MagicCaster(string name) : base(name)
    {
        EnemyHealth = 80;
        EnemyAttackList = new List<Attack>()
        {
            new Attack("Fireball", 25),
            new Attack("Lightning Strike", 20),
            new Attack("Staff Striike", 10),
        };
    }

    //Heal Method
    //this MagicCaster heals a targets Enemy Character for 40 health and displays the new health at the end
    public void Heal(Enemy target)
    {
        int healAmount = 40;
        target.EnemyHealth += healAmount;
        Console.WriteLine($"{this.NameOfEnemy} heals {target.NameOfEnemy} for {healAmount} health. {target.NameOfEnemy}'s health is now {target.EnemyHealth}.");
    }
}        