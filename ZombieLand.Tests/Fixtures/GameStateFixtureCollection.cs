using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieLand.Tests.Fixtures
{
    [CollectionDefinition(GameStateFixtureCollection.CollectionName)]
    public class GameStateFixtureCollection : ICollectionFixture<GameStateFixture>
    {
        public const string CollectionName = "Fixture Collection";
    }
}
