namespace ZombieLand.GameEngine
{
    public  class NormalEnemy : Enemy
    {
        public override double TotalSpecialPower => 100;
        public override double SpecialPowerUses => 2;

        public override bool Equals(object? other)
        {
            if (other is NormalEnemy enemy)
                if (this.Name == enemy.Name)
                    return true;

            return false;
        }

        public static bool operator ==(NormalEnemy enemy, NormalEnemy other)
        {
            return Equals(enemy, other);
        }

        public static bool operator !=(NormalEnemy enemy, NormalEnemy other)
        {
            //return !(enemy == other);
            return !Equals(enemy, other);
        }

        public override int GetHashCode()
            => Name.GetHashCode();
    }
}