namespace ZombieLand.GameEngine
{
    public class GameState
    {
        public List<PlayerCharacter> Players { get; set; } = new();
        public Guid Id { get; } = Guid.NewGuid();
    }
}
