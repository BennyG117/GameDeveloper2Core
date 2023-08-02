public class RangedFighter : Enemy
{
    public int DistanceField {get; set;}
    //Constructors --------------
    public RangedFighter(string name) : base(name)
    {
        DistanceField = 5;
        EnemyAttackList = new List<Attack>()
        {
            new Attack("Bow and Arrows", 20),
            new Attack("Throws a knife", 15),
        };
    }

        // Distance Method
        //Can't perform an attack if Distance is less than 10
        public bool Distance(Enemy target)
        {
            if (DistanceField >= 10)
            {
                // Console.WriteLine($"{this.NameOfEnemy} is within range to attack!");
                return true;
            }
            else
            {
                // Console.WriteLine($"{this.NameOfEnemy} is too close to {target.NameOfEnemy}. {this.NameOfEnemy} can't attack!");
                return false;
            }
        }

        //Dash Method
        //fighter performs a dash, setting distance to 20

        public void Dash()
        {
            DistanceField = 20;
            Console.WriteLine($"{this.NameOfEnemy} dashed to a new position {DistanceField}ft away, and can now attack!");
        }

        //Update PerformAttack Method to accomidate the range...
        public void PerformAttack(Enemy target, Attack choosenAttack)
        {
            if (!Distance(target))
            {
                Console.WriteLine($"{this.NameOfEnemy} Can't attack {target.NameOfEnemy}, they're too close!");
                return;
            }
            base.PerformAttack(target, choosenAttack);
        }
}