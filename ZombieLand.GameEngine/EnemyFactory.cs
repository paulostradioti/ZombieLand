using GameEngine;

namespace ZombieLand.GameEngine
{
    public class EnemyFactory
    {
        public Enemy Create(string name, bool isBoss = false)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            #region Checagem Is Boss
            if (isBoss)
            {
                if (!IsValidBossName(name))
                {
                    throw new EnemyCreationException(
                        $"{name} is not a valid name for a Boss enemy, Boss enemy names must end with 'King' or 'Queen'",
                        name);
                }

                return new BossEnemy { Name = name };
            }
            #endregion
            return new NormalEnemy { Name = name };
        }

        #region Checagem Is Boss - Name
        private bool IsValidBossName(string name) => name.EndsWith("King") ||
                                                     name.EndsWith("Queen");
        #endregion
    }
}
