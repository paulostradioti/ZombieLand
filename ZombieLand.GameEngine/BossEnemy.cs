using ZombieLand.GameEngine;

namespace GameEngine
{
    public class BossEnemy : Enemy
    {
        public override double TotalSpecialPower => 100;
        public override double SpecialPowerUses => 6;
    }
}
