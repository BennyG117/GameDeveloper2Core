public class Enemy
{
    //Fields --------------
    public string NameOfEnemy;

    public int EnemyHealth {get; set;}

    public List<Attack> EnemyAttackList;




    //Constructors --------------
    public Enemy(string nameOfEnemy)
    {
        NameOfEnemy = nameOfEnemy;
        EnemyHealth = 100;
        EnemyAttackList = new List<Attack>();
    }


    //Method --------------
    public Attack RandomAttack()
    {
        Random random = new Random();
        int randomAttackIndex = random.Next(0, EnemyAttackList.Count);
        Attack randomAttack = EnemyAttackList[randomAttackIndex];

        return randomAttack;
        // Console.WriteLine($"{NameOfEnemy} attacked with {randomAttack.NameOfAttack} ");
    }

    public void AddToAttackList(Attack newAttack)
    {
        EnemyAttackList.Add(newAttack);
    }


    public void PerformAttack(Enemy Target, Attack banana)
    {
        //updating enmemy's health after damage is taken
        Target.EnemyHealth = Target.EnemyHealth - banana.DamageAmount;

        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        Console.WriteLine($"{this.NameOfEnemy} attacks {Target.NameOfEnemy} with {banana.NameOfAttack}, dealing {banana.DamageAmount} damage and reducing {Target.NameOfEnemy}'s health to {Target.EnemyHealth}!!");
    }


}