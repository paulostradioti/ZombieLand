using ZombieLand.GameEngine;

namespace ZombieLand.Tests.Fixtures
{
    public class GameStateFixture
    {
        public GameState State { get; private set; }

        public GameStateFixture()
        {
            State = new GameState();

            State.Players.Add(new PlayerCharacter());
            State.Players.Add(new PlayerCharacter());
        }
    }
}
