public class MeleeFighter : Enemy
{
    //Constructors --------------
    public MeleeFighter(string name) : base(name)
    {
        EnemyHealth = 120;
        EnemyAttackList = new List<Attack>()
        {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
        

    }

    //Rage Method - random attack from its attack list, but +10 dmg...
        public void Rage(Enemy target)
    {
        Attack rageAttackAbility = this.RandomAttack();
        //+10 damage to 
        rageAttackAbility.DamageAmount +=10;
        this.PerformAttack(target, rageAttackAbility);
        rageAttackAbility.DamageAmount -=10;

    }

    // public override PerformAttack(Enemy Target, Attack choosenAttack)
    // {
        
    // }

}