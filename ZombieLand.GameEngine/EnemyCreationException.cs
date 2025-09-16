namespace ZombieLand.GameEngine
{
    public class EnemyCreationException : DomainException
    {
        public EnemyCreationException(string message, string enemyName) : base(message)
        {
            RequestedEnemyName = enemyName;
        }

        public string RequestedEnemyName { get; private set; }
    }

    public class DomainException : Exception
    {
        private string message;

        public DomainException(string message) : base(message)
        {
            this.message = message;
        }
    }
}
